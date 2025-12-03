using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    public class Query
    {
        public string atributos = "";
        
        #region TABLAS

        public string PRODUCTO = "producto";
        public string PROVEEDOR = "proveedor";
        public string UNIDAD_LIST = "unidad_list";
        public string VENTA = "venta";
        public string DETALLE_VENTA = "detalle_venta";
        public string CLIENTE = "cliente";
        public string PPREDIO = "Predio";
        public string COMPRAVENTA = "CompraVenta";
        public string SESSIONS = "SESSIONS";
        public string USUARIO = "Usuario";
        public string COMISION = "Comision";
        public string PROXIMOPAGO = "ProximoPago";

        #endregion

        #region PALABRAS RESERVADAS SQL
        public string INSERT_INTO = "INSERT INTO";
        public string SELECT = "SELECT";
        public string FROM = "FROM";
        public string VALUES = "VALUES";
        public string UPDATE = "UPDATE";
        public string SET = "SET";
        public string igual = " = ";
        public string AND = "AND";
        public string ORDEN_BY = "ORDER BY";
        public string ASC = "ASC";
        public string WHERE = "WHERE";
        public string MAX_ID = "MAX";
        public string LIKE = "LIKE";
        public string CURRENT_TIMESTAMP = "DATE_FORMAT(CURRENT_TIMESTAMP(), '%d-%m-%Y %T')";
        public string DATE_CAST = "dd-MM-yyyy HH:mm:ss";
        public string DATE_TIME = "DATE_TIME";

        public string abrir_parentesis = "(";
        public string cerrar_parentesis = ")";
        public string c = "'";
        public string cc = ",";
        public string ccc = "','";

        #endregion

        #region metodos venta

        public string id_venta_a = "id_venta";

        public string insertarVenta()
        {
            return "INSERT INTO VENTA(fecha,hora,fk_id_cliente)"+
                   "VALUES((select strftime('%d/%m/%Y', datetime('now'))),(select strftime('%H:%M:%S', datetime('now'))), 1)";
        }

        public string eliminarVenta()
        {
            return "DELETE FROM VENTA WHERE id_venta = (SELECT MAX(id_venta) FROM `VENTA`)";
        }
        #endregion

        #region detalle Venta
        public string insertarDetalleVenta(string cantidad,string idProducto)
        { 
            return "INSERT INTO `detalle_venta`(`cantidad`,`fk_id_venta`,`fk_id_producto`)"+
                   "VALUES ('"+cantidad+ "',(SELECT MAX(id_venta) FROM `VENTA`),'" + idProducto+"')";
        }

        public string queryEliminarDetalleVenta()
        {
            return $"DELETE FROM detalle_venta WHERE fk_id_venta = (SELECT MAX(id_venta) FROM `{DETALLE_VENTA}`)";
        }

        public string clienteCredito()
        {
            return "SELECT `id_venta` AS folio, `nombre` As cliente , `fecha` , SUM(detalle_venta.`cantidad` * `precio_venta`) AS total, `descuento`, `abono`, `fk_id_cliente` FROM `venta` INNER JOIN `cliente` , `detalle_venta` , `producto` WHERE venta.`id_venta` = detalle_venta.`fk_id_venta` AND `id_cliente` = `fk_id_cliente` AND `codigo` = `fk_codigo_producto` AND `credito` = ? GROUP BY `id_venta`";
        }

        public string corteCaja()
        {
            return "SELECT `id_venta` AS Folio, `nombre` As cliente , `fecha` AS fecha, SUM(detalle_venta.`cantidad` * `precio_venta`) AS total, `descuento`, SUM(detalle_venta.`cantidad` * `precio_costo`) AS costo FROM `venta` INNER JOIN `cliente` , `detalle_venta` , `producto` WHERE venta.`id_venta` = detalle_venta.`fk_id_venta` AND `id_cliente` = `fk_id_cliente` AND `codigo` = `fk_codigo_producto` GROUP BY `fecha` ORDER BY `id_venta` DESC";
        }

        public string id_detalle_venta_a = "id_detalle_venta";
        public string fk_id_venta_a = "fk_id_venta";
        public string fk_codigo_producto_a = "fk_codigo_producto";
        #endregion

        #region metodos producto
        public string id_producto_a = "id_producto";
        public string codigo_a = "codigo";
        public string unidad_a = "unidad";
        public string precio_venta_a = "precio_venta";
        public string precio_costo_a = "precio_costo";
        public string descripcion_a = "descripcion";
        public string cantidad_a = "cantidad";
        public string fk_id_proveedor_a = "fk_id_proveedor";

        public string insertarProducto(string codigo, string precioVenta, string precioCosto, string descripcion, string cantidad)
        {
            return "INSERT INTO PRODUCTO(codigo, precio_venta, precio_costo, descripcion, cantidad, fk_id_proveedor)" +
                   "VALUES('"+codigo+"','"+precioVenta+"','"+precioCosto+"','"+descripcion+"','"+cantidad+"', 0)";  
        }

        public string cargarProducto(string codigo)
        {
            return "SELECT id_producto, codigo, precio_venta, precio_costo, descripcion, cantidad, fk_id_proveedor FROM PRODUCTO WHERE  codigo = '" + codigo + "'";
        }

        public string buscarProducto(string descripcion)
        {
            return "SELECT codigo AS CODIGO, descripcion AS DESCRIPCION, precio_venta AS 'PRECIO VENTA', precio_costo AS 'PRECIO COSTO' FROM PRODUCTO WHERE descripcion LIKE '%" + descripcion+"%'";
        }

        public string actualizarProducto(string codigo, string precioVenta, string precioCosto, string descripcion, string cantidad, string idProducto)
        {
            return "UPDATE `PRODUCTO` SET "+
                   "`codigo`= '"+codigo+"', `descripcion`= '"+descripcion+"', precio_venta = '"+precioVenta+"', "+
                   "precio_costo = '"+precioCosto+"', cantidad = '"+cantidad+"'"+
                   "WHERE id_producto = '"+idProducto+"'";
        }

        
        //public string codigo_a = "codigo";
        #endregion

        #region caja
        public string corteCaja(string fecha)
        {
            return "SELECT SUM(p.precio_venta) FROM PRODUCTO AS p INNER JOIN DETALLE_VENTA AS d ON d.fk_id_producto = p.id_producto INNER JOIN VENTA AS v ON  v.id_venta =  d.fk_id_venta WHERE v.fecha = '"+fecha+"'";
        }
        #endregion

        #region usuario
        public string insertarUsuario(string nombre, string contraseña, string roll)
        {
            return $"INSERT INTO USUARIO(`nombre`,`contraseña`,`roll`) VALUES (`{nombre}`,`{contraseña}`,`{roll}`";
        }

        public string buscarUsuario(string nombre)
        {
            return $"SELECT `{nombre}` FROM USUARIO WHERE `nombre` = {nombre}`";
        }

        public string actualizarUsuario(string nombre, string contraseña, string roll, string id)
        {
            return $"UPDATE USUARIO SET nombre = '{nombre}', contraseña = '{contraseña}', roll = `{roll}` WHERE id_usuario = '{id}'";
        }

        #endregion

        #region proveedor
        public string id_proveedor_a = "id_proveedor";
        #endregion

        #region cliente
        public string id_cliente_a = "id_cliente";

        #endregion

        public string maxId(string tabla, string atributo)
        {
            
            return $"{SELECT} * {FROM} {tabla} {ORDEN_BY} {atributo} DESC LIMIT 1";
            
            //$"{SELECT} * {FROM} {tabla} {WHERE} {atributo} {igual} " +
            //$"{abrir_parentesis} {SELECT} {MAX_ID}{abrir_parentesis}{atributo}{cerrar_parentesis} {FROM} {tabla}";
        }

        public string queryConsulta(string atributo, string tabla, string condicion)
        {
            return $"SELECT {atributo} FROM {tabla} {condicion}";
        }

        public string llenarComboBox(string columna, string tabla)
        {
            return "SELECT "+columna+" FROM "+tabla+" ORDER BY "+columna+" ASC"; 
        }

        #region METODOS
        public string queryInsertar(string tabla, string atributos, string valores)
        {
            return "INSERT INTO" + tabla + atributos + "VALUES" + valores;
        }

        public string execute(string tabla, string values, action action, string condicion)
        {
            switch (action)
            {
                case action.insert:
                    return $"INSERT INTO {tabla} ({Atributos(tabla)}) VALUES ({values})";
                case action.update:
                    return $"UPDATE {tabla} SET {values} {condicion}";
                case action.query:
                    return $"SELECT {values},{Atributos(tabla)} FROM {tabla} {condicion}";
                case action.free:
                    return condicion;

                default:
                    return "";
            }

            //return "SELECT " + atributo + " FROM " + tabla + condicion;
        }

        public string Atributos(string tabla)
        {
            switch (tabla)
            {
                case "producto":
                    return "codigo, unidad, precio_venta, precio_costo, descripcion, cantidad, fk_id_proveedor";
                case "proveedor":
                    return "`nombre`,`direccion`,`telefono`";
                case "detalle_venta":
                    return "`cantidad`,`fk_id_venta`,`fk_codigo_producto`";
                case "venta":
                    return "`fecha`,`fk_id_cliente`,`credito`,`descuento`,`abono`";
                case "cliente":
                    return "`nombre`,`direccion`,`ciudad`,`estado`,`rfc`,`correo`,`telefono`";
;                default:
                    return "";
            }
        }

        public string queryActualizar(string tabla, string valores, string condicion)
        {
            return "UPDATE " + tabla + " SET " + valores + condicion;
        }

        public string Where(string atributos, string valores)
        {
            return $"WHERE {atributos} {igual} {valores}";
        }
        //public string consultaLike(string atributo, string tabla, string nombre)
        //{
        //    return "SELECT "+atributo+" FROM "+tabla+" WHERE nombre LIKE '%"+nombre+"%'";
        //}

        public string maxId(string atributo)
        {
            //return MAX_ID + abrirParentesis + atributo + cerrarParantesis;
            return "";
        }
        #endregion
    }
}
