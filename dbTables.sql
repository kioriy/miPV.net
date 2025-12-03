--  Creado con Kata Kuntur - Modelador de Datos
--  Versión: 2.5.2
--  Sitio Web: http://katakuntur.jeanmazuelos.com/
--  Si usted encuentra algún error le agradeceriamos lo reporte en:
--  http://pm.jeanmazuelos.com/katakuntur/issues/new

--  Administrador de Base de Datos: SQLite
--  Diagrama: dbmiPV
--  Autor: ikioriy
--  Fecha y hora: 17/07/2017 21:54:13
PRAGMA foreign_keys = ON;

-- GENERANDO TABLAS
CREATE TABLE PRODUCTO (
	id_producto INTEGER NOT NULL ,
	precio_venta DECIMAL(10,2) NOT NULL ,
	precio_costo DECIMAL(10,2) NOT NULL ,
	descripcion VARCHAR(200) NOT NULL ,
	cantidad DECIMAL(4,1) NOT NULL ,
	unidad  NOT NULL ,
	fk_id_proveedor INTEGER NOT NULL ,
	FOREIGN KEY (fk_id_proveedor) REFERENCES PROVEEDOR(id_proveedor),
	PRIMARY KEY(id_producto)
);
CREATE TABLE CLIENTE (
	id_cliente INTEGER NOT NULL ,
	nombre VARCHAR(100) NOT NULL ,
	direccion VARCHAR(150) NOT NULL ,
	ciudad VARCHAR(50) NOT NULL ,
	estado VARCHAR(50) NOT NULL ,
	rfc VARCHAR(20) NOT NULL ,
	correo VARCHAR(50) NOT NULL ,
	telefono VARCHAR(20) NOT NULL ,
	PRIMARY KEY(id_cliente)
);
CREATE TABLE VENTA (
	id_venta INTEGER NOT NULL ,
	fecha DATE NOT NULL ,
	fk_id_cliente INTEGER NOT NULL ,
	FOREIGN KEY (fk_id_cliente) REFERENCES CLIENTE(id_cliente),
	PRIMARY KEY(id_venta)
);
CREATE TABLE PROVEEDOR (
	id_proveedor INTEGER NOT NULL ,
	nombre VARCHAR(100) NOT NULL ,
	direccion VARCHAR(150) NOT NULL ,
	telefono VARCHAR(20) NOT NULL ,
	PRIMARY KEY(id_proveedor)
);
CREATE TABLE DETALLE_VENTA (
	id_venta INTEGER NOT NULL ,
	cantidad DECIMAL(4,1) NOT NULL ,
	fk_id_venta INTEGER NOT NULL ,
	fk_id_producto INTEGER NOT NULL ,
	FOREIGN KEY (fk_id_venta) REFERENCES VENTA(id_venta),
	FOREIGN KEY (fk_id_producto) REFERENCES PRODUCTO(id_producto),
	PRIMARY KEY(id_venta)
);