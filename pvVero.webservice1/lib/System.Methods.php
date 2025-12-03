<?php

//include_once 'lib/DB.php';
require_once 'DB.php';
//require_once 'nusoap/nusoap.php';//comentar esta linea para subir a produccion

function query($table, $values, $action, $where)

{
  if($values != "")
  {
    $values = explode("," , $values);
  }


  $data = DB::getInstance()->query($table, $values ,$action, $where);
  //$data = DB::getInstance()->query("`USERS`", $values ,'insert', "");//$result->fetch_assoc();
  //$data = DB::getInstance()->query("`USERS`", $values ,'query', $where);//$result->fetch_assoc();
  //$data = DB::getInstance()->query("`USERS`", $values ,'update', $where);

  if(!is_array($data))
  {
    if($data)
    {
      //return $data;
      //return json_encode($data);
      return new soapval('return','xsd:string', json_encode($data, JSON_UNESCAPED_UNICODE));
      //return new soapval('return','xsd:string', $data);
    }
    else
    {
      //return 'false';
      return new soapval('return','xsd:string', 'false');
    }
  }
  else
  {
    //return $data;
    //return json_encode($data);
    return new soapval('return','xsd:string', json_encode($data, JSON_UNESCAPED_UNICODE));
    //return new soapval('return','xsd:string', $data);
  }
}
?>
