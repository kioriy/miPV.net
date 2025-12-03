<?php

require_once 'config.php';

class DB
{
    protected static $_instance;
    protected $mysqli;
    protected $stmt;
    protected $metadata_name;
    public static $_attributes;
    public static $_set_attributes;
    public static $_type;
    public static $_values_update;
    public static $_metadata_attributes;
    public static $_idAttribute;


    protected function __construct(){}

    public static function getInstance()
    {
        if (!isset(self::$_instance))
        {
          self::$_instance = new DB();
        }
        return self::$_instance;
    }

    /*
     * Devuelve el arreglo asociativo de la consulta, Resuelve cualquiera de
     * las consultas insert, query, update, mandando el nombre de la tabla
     * los valores en una cadena separada por comas "value1,value2,values3..."
     * en caso de existir una condicion se manda "WHERE `attribute`= ? AND `attribute` = ?"
     *
     * @param [string] $table
     * @param [string] $values
     * @param [string] $action
     * @param [string] $where
     * @return array()
     */

    public function query($table, $values, $action, $where)
    {
        $values = $this->addDateTimeStamp($values);
        $query = $this->returnQuery($table, $values, $action, $where);

        if($result = $this->prepare($query))
        {
            if($result = $this->bind_param($values))
            {
                if($result = $this->execute())
                {
                    if($action == 'query' || $action == 'free')
                    {
                        return $this->getResult();
                        //return array($result, "action query true");
                    }
                    //return array($this->stmt, $result, "es true en execute", $this->stmt->num_rows);
                    return $result;
                }
                else
                {
                    //return array($result, "execute");
                    return $result;
                }
                //return array($result, "es true en bind_param");
                return $result;
            }
            else
            {
                //return array($result, "bind_param");
                return $result;
            }
            //return array($result,"es true en prepare");
            return $result;
        }
        else
        {
            //return array($result, "prepare false");
            return $result;
        }
    }

    protected function prepare($query)
    {
        if(($this->stmt = $this->_connect()->prepare($query)))
        {
            return $this->stmt;
        }
        return $this->stmt;
    }

    protected function bind_param($values)
    {
        $result = true;

        if(!empty($values))
        {
            /*if(($result = $this->stmt->bind_param("s", $values)))
            {
                return $result;
            }*/
            $reflection = new ReflectionClass('mysqli_stmt');
            $method = $reflection->getMethod("bind_param");
            $values = $this->typeAndValuesArray($values);
            $result = $method->invokeArgs($this->stmt, $values);

            return $result;
            //return $type_and_values;
            //return $values;
        }
        return $result;
    }

    protected function execute()
    {
        if(($result = $this->stmt->execute()))
        {
            return $result;
        }
        return $result;
    }

    protected function getResult()
    {
        return $this->bindResult();

        return $result;

        //esta implementacion funciona caundo esta instalado mysqlnd
        /*$stmt = $this->stmt->get_result();//$this->stmt->get_result()->fetch_assoc();
        //$error = $this->stmt->errno();
        $this->close();

        while($row = $stmt->fetch_assoc())
        {
            $result[] = $row;
            //$result .= $row;
        }
        return $result;//$stmt;//$this->stmt->get_result()->fetch_assoc();
        //return $stmt;*/
    }

    public function bindResult()
    {
        $result = array();
        $md = $this->stmt->result_metadata();
        $params = array();
        
        while ($field = $md->fetch_field())
        {
            $params[] = &$result[$field->name];
        }

        call_user_func_array(array($this->stmt, 'bind_result'), $params);

        while ($this->stmt->fetch())
        {
            $data[] = $this->arrayCopy($result);
        }
        return $data;
    }

    function arrayCopy(array $array)
    {
        $result = array();

        foreach( $array as $key => $val )
        {
            if( is_array( $val ))
            {
                $result[$key] = $val; //arrayCopy( $val );
            }
            elseif ( is_object( $val ) )
            {
                $result[$key] = clone $val;
            }
            else
            {
                $result[$key] = $val;
            }
        }
        return $result;
    }

    public function getMetaData($stmt)
    {
        $result = $stmt->result_metadata();

        return $result;
    }

    public function close()
    {
        $this->stmt->close();
        $this->mysqli->close();
    }

    public function attributes($table)
    {
        $stmt = $this->prepare("SELECT * FROM $table");

        self::$_metadata_attributes = $this->getMetaData($stmt)->fetch_fields();

        $items = count(self::$_metadata_attributes);
        $flag = false;

        foreach (self::$_metadata_attributes as $campo)
        {
            if($flag)
            {
                self::$_attributes .= "`".$campo->name."`";
                self::$_set_attributes .= "?";
                $this->metadata_name[] = &$campo->name;

                $items--;

                if ($items > 1)
                {
                    self::$_attributes .= ", ";
                    self::$_set_attributes .= ", ";
                }
            }
            else
            {
                $flag = true;
                self::$_idAttribute = "`".$campo->name."`,";
            }
        }
    }

    public function valuesUpdateString($values)
    {
        $attributes = explode(",", self::$_attributes);

        $items = count($attributes);

        for ($i=0; $i < $items; $i++)
        {
            self::$_values_update .="$attributes[$i] = ?";

            if ($i < ($items-1))
            {
                self::$_values_update .= ", ";
            }
        }
    }

    public function typeAttributes($values)
    {
        $items = count($values);

        for ($i=0; $i < $items ; $i++)
        {
            self::$_type .= 's';
        }
        /*foreach($values as $value)
        {
            if(is_string($value))
            {
                self::$_type .= 's';
            }
            if ($type == 253 || $type == 12)
            {
                self::$_type .= 's';
            }
        }*/
        //if ($type == 3)
        //{
        //  self::$_type .= 'i';
        //}
    }

    public function typeAndValuesArray($values)
    {
        $values = array_merge((array)self::$_type, $values);

        $reference = array();

        foreach($values as $key => $value)
        {
            $reference[$key] = &$values[$key];
        }
        return $reference;
    }

    public function returnQuery($table, $values, $action, $where)
    {
        //$this->addDateTimeStamp($values);
        $this->attributes($table);
        $this->valuesUpdateString($values);
        $this->typeAttributes($values);
        $attributes = self::$_attributes;
        $set_attributes = self::$_set_attributes;
        $values_update = self::$_values_update;
        $idAttribute = self::$_idAttribute;

        switch ($action)
        {
            case 'insert':
                return "INSERT INTO $table($attributes) VALUES ($set_attributes)";
                break;

            case 'query':
                return "SELECT $idAttribute$attributes FROM $table $where";
                break;

            case 'update':
                return "UPDATE $table SET $values_update $where";
                break;

            case 'free':
                return "$where";
                break;

            default:
                # code...
                break;
        }
    }

    public function addDateTimeStamp($values)
    {
        if(!empty($values))
        {
            for ($i=0; $i < count($values); $i++)
            {
                if($values[$i] == 'DATE_TIME')
                {
                    $result = $this->dateTimeStamp();
                    $date_time = $result[0];
                    $values[$i] = $date_time['Date_Time'];
                }
            }
        }
        return $values;
    }

    public function dateTimeStamp()
    {
      $this->prepare("SELECT DATE_FORMAT(CURRENT_TIMESTAMP(), '%d-%m-%Y %T') as Date_Time");
      $this->execute();
      return $this->getResult();
    }

    /*public function addMaxId()
    {
        for ($i=0; $i < count($values); $i++)
        {
            if($values[$i] == 'MAX')
            {
                $result = $this->maxId();
                $date_time = $result[0];
                $values[$i] = $date_time['Max_Id'];
            }
        }

        return $values;
    }
    
    public function maxId($table)
    {
      $this->prepare("SELECT MAX(self::$_idAttribute) FROM $table AS Max_Id");
      $this->execute();
      return $this->getResult();
    }*/

    protected function _connect()
    {
        if (!isset($this->mysqli))
        {
            $this->mysqli = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAM);
            $this->mysqli->set_charset("utf8");
        }
        return $this->mysqli;
    }
}
?>
