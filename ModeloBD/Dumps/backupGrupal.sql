-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: quilla.lab.inf.pucp.edu.pe    Database: inf282g2
-- ------------------------------------------------------
-- Server version	5.5.54

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `al_almacen`
--

DROP TABLE IF EXISTS `al_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_almacen` (
  `idAlmacen` varchar(10) NOT NULL,
  `Sucursal_idSucursal` varchar(10) NOT NULL,
  `habilitado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idAlmacen`),
  KEY `fk_Almacen_Sucursal1_idx` (`Sucursal_idSucursal`),
  CONSTRAINT `fk_Almacen_Sucursal1` FOREIGN KEY (`Sucursal_idSucursal`) REFERENCES `al_sucursal` (`idSucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_almacen`
--

LOCK TABLES `al_almacen` WRITE;
/*!40000 ALTER TABLE `al_almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `al_ingreso_producto`
--

DROP TABLE IF EXISTS `al_ingreso_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_ingreso_producto` (
  `idIngresoProducto` varchar(10) NOT NULL,
  `Producto_idProducto` varchar(10) NOT NULL,
  `Almacen_idAlmacen` varchar(10) NOT NULL,
  `cantidadIngreso` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  PRIMARY KEY (`idIngresoProducto`,`Producto_idProducto`,`Almacen_idAlmacen`),
  KEY `fk_IngresoProducto_Almacen1_idx` (`Almacen_idAlmacen`),
  KEY `fk_IngresoProducto_Producto1` (`Producto_idProducto`),
  CONSTRAINT `fk_IngresoProducto_Almacen1` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `al_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_IngresoProducto_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `al_producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_ingreso_producto`
--

LOCK TABLES `al_ingreso_producto` WRITE;
/*!40000 ALTER TABLE `al_ingreso_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_ingreso_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `al_pedido_a_produccion`
--

DROP TABLE IF EXISTS `al_pedido_a_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_pedido_a_produccion` (
  `ID_PEDIDO` int(11) NOT NULL,
  `ID_PRODUCTO` int(11) NOT NULL,
  `CANTIDAD` int(11) NOT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_PEDIDO`,`ID_PRODUCTO`),
  CONSTRAINT `ID_PRODUCTO` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `prod_productos` (`ID_PRODUCTO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_pedido_a_produccion`
--

LOCK TABLES `al_pedido_a_produccion` WRITE;
/*!40000 ALTER TABLE `al_pedido_a_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_pedido_a_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `al_producto`
--

DROP TABLE IF EXISTS `al_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_producto` (
  `idProducto` varchar(10) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `habilitado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_producto`
--

LOCK TABLES `al_producto` WRITE;
/*!40000 ALTER TABLE `al_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `al_producto_almacen`
--

DROP TABLE IF EXISTS `al_producto_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_producto_almacen` (
  `Almacen_idAlmacen` varchar(10) NOT NULL,
  `Producto_idProducto` varchar(10) NOT NULL,
  PRIMARY KEY (`Almacen_idAlmacen`,`Producto_idProducto`),
  KEY `fk_ProductoAlmacen_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_ProductoAlmacen_Almacen` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `al_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProductoAlmacen_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `al_producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_producto_almacen`
--

LOCK TABLES `al_producto_almacen` WRITE;
/*!40000 ALTER TABLE `al_producto_almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_producto_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `al_salida_producto`
--

DROP TABLE IF EXISTS `al_salida_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_salida_producto` (
  `idSalidaProducto` varchar(10) NOT NULL,
  `cantidadSalida` int(11) NOT NULL,
  `fechaSalida` datetime NOT NULL,
  `Producto_idProducto` varchar(10) NOT NULL,
  `Almacen_idAlmacen` varchar(10) NOT NULL,
  PRIMARY KEY (`idSalidaProducto`,`Producto_idProducto`,`Almacen_idAlmacen`),
  KEY `fk_SalidaProducto_Producto1_idx` (`Producto_idProducto`),
  KEY `fk_SalidaProducto_Almacen1_idx` (`Almacen_idAlmacen`),
  CONSTRAINT `fk_SalidaProducto_Almacen1` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `al_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_SalidaProducto_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `al_producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_salida_producto`
--

LOCK TABLES `al_salida_producto` WRITE;
/*!40000 ALTER TABLE `al_salida_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_salida_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `al_sucursal`
--

DROP TABLE IF EXISTS `al_sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `al_sucursal` (
  `idSucursal` varchar(10) NOT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Falta conectar con clientes y con vehiculos.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `al_sucursal`
--

LOCK TABLES `al_sucursal` WRITE;
/*!40000 ALTER TABLE `al_sucursal` DISABLE KEYS */;
/*!40000 ALTER TABLE `al_sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gen_compania`
--

DROP TABLE IF EXISTS `gen_compania`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_compania` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `id_persona_representa` bigint(15) DEFAULT NULL,
  `ruc` varchar(20) DEFAULT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `id_pais` bigint(15) DEFAULT NULL,
  `id_user_registro` bigint(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_6` (`id_pais`),
  KEY `REL_5` (`id_persona_representa`),
  CONSTRAINT `REL_5` FOREIGN KEY (`id_persona_representa`) REFERENCES `gen_persona` (`id`),
  CONSTRAINT `REL_6` FOREIGN KEY (`id_pais`) REFERENCES `gen_pais` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_compania`
--

LOCK TABLES `gen_compania` WRITE;
/*!40000 ALTER TABLE `gen_compania` DISABLE KEYS */;
/*!40000 ALTER TABLE `gen_compania` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gen_pais`
--

DROP TABLE IF EXISTS `gen_pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_pais` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) DEFAULT NULL,
  `codigo` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_pais`
--

LOCK TABLES `gen_pais` WRITE;
/*!40000 ALTER TABLE `gen_pais` DISABLE KEYS */;
/*!40000 ALTER TABLE `gen_pais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gen_persona`
--

DROP TABLE IF EXISTS `gen_persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_persona` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `paterno` varchar(50) NOT NULL,
  `materno` varchar(50) DEFAULT NULL,
  `nombres` varchar(50) NOT NULL,
  `primer_nombre` varchar(50) DEFAULT NULL,
  `segundo_nombre` varchar(50) DEFAULT NULL,
  `sexo` varchar(1) DEFAULT NULL,
  `fecha_nacer` date DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `id_tipo_doc_identidad` bigint(15) NOT NULL,
  `numero_doc_identidad` varchar(25) NOT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `id_user_registro` bigint(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_modificación` bigint(15) DEFAULT NULL,
  `fecha_moficacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQUE_Persona_1` (`numero_doc_identidad`,`email`),
  KEY `REL_1` (`id_tipo_doc_identidad`),
  CONSTRAINT `REL_1` FOREIGN KEY (`id_tipo_doc_identidad`) REFERENCES `gen_tipo_doc_identidad` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_persona`
--

LOCK TABLES `gen_persona` WRITE;
/*!40000 ALTER TABLE `gen_persona` DISABLE KEYS */;
/*!40000 ALTER TABLE `gen_persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gen_tipo_doc_identidad`
--

DROP TABLE IF EXISTS `gen_tipo_doc_identidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_tipo_doc_identidad` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `id_pais` bigint(15) DEFAULT NULL,
  `codigo` varchar(30) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `simbolo` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_4` (`id_pais`),
  CONSTRAINT `REL_4` FOREIGN KEY (`id_pais`) REFERENCES `gen_pais` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_tipo_doc_identidad`
--

LOCK TABLES `gen_tipo_doc_identidad` WRITE;
/*!40000 ALTER TABLE `gen_tipo_doc_identidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `gen_tipo_doc_identidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_detalles_lista_produccion`
--

DROP TABLE IF EXISTS `prod_detalles_lista_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_detalles_lista_produccion` (
  `ID_LISTA_PRODUCCION` int(11) NOT NULL,
  `ID_PEDIDO` int(11) NOT NULL,
  `ID_PRODUCTO` int(11) NOT NULL,
  `CANTIDAD_SOLICITADA` int(11) DEFAULT NULL,
  `CANTIDAD_FABRICADA` int(11) DEFAULT NULL,
  `FECHA_TRANSACCION` date DEFAULT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_LISTA_PRODUCCION`,`ID_PEDIDO`,`ID_PRODUCTO`),
  KEY `ID_PEDIDO _idx` (`ID_PEDIDO`),
  KEY `ID_PRODUCTO _idx` (`ID_PRODUCTO`),
  CONSTRAINT `ID_LIST_PROD` FOREIGN KEY (`ID_LISTA_PRODUCCION`) REFERENCES `prod_listas_produccion` (`ID_LISTA_PRODUCCION`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ID_PED` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `al_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ID_PRODUC` FOREIGN KEY (`ID_PRODUCTO`) REFERENCES `prod_productos` (`ID_PRODUCTO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_detalles_lista_produccion`
--

LOCK TABLES `prod_detalles_lista_produccion` WRITE;
/*!40000 ALTER TABLE `prod_detalles_lista_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_detalles_lista_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_estados`
--

DROP TABLE IF EXISTS `prod_estados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_estados` (
  `ID_ESTADO` int(11) NOT NULL,
  `NOMBRE` varchar(100) NOT NULL,
  `DESCRIPCION` varchar(100) NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_ESTADO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_estados`
--

LOCK TABLES `prod_estados` WRITE;
/*!40000 ALTER TABLE `prod_estados` DISABLE KEYS */;
INSERT INTO `prod_estados` VALUES (1,'EstadoFranco','HOLIWIS',1),(2,'EstadoRodrigo','HOLIWIS x2',1),(3,'EstadoJosias','HOLIWIS x3',1);
/*!40000 ALTER TABLE `prod_estados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_listas_produccion`
--

DROP TABLE IF EXISTS `prod_listas_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_listas_produccion` (
  `ID_LISTA_PRODUCCION` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PEDIDO` int(11) NOT NULL,
  `FECHA_CREACION` date DEFAULT NULL,
  `ESTADO` int(11) DEFAULT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_LISTA_PRODUCCION`,`ID_PEDIDO`),
  KEY `ESTADO _idx` (`ESTADO`),
  CONSTRAINT `ID_PEDIDO ` FOREIGN KEY (`ID_LISTA_PRODUCCION`) REFERENCES `al_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ESTADO ` FOREIGN KEY (`ESTADO`) REFERENCES `prod_estados` (`ID_ESTADO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_listas_produccion`
--

LOCK TABLES `prod_listas_produccion` WRITE;
/*!40000 ALTER TABLE `prod_listas_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_listas_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_manivelas`
--

DROP TABLE IF EXISTS `prod_manivelas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_manivelas` (
  `ID_MANIVELA` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(100) DEFAULT NULL,
  `DIAMETRO` varchar(10) DEFAULT NULL,
  `UNIDADES` int(11) DEFAULT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_MANIVELA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_manivelas`
--

LOCK TABLES `prod_manivelas` WRITE;
/*!40000 ALTER TABLE `prod_manivelas` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_manivelas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_perillas`
--

DROP TABLE IF EXISTS `prod_perillas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_perillas` (
  `ID_PERILLA` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(100) DEFAULT NULL,
  `DIAMETRO` varchar(10) DEFAULT NULL,
  `LONGITUD` varchar(10) DEFAULT NULL,
  `UNIDADES` int(11) DEFAULT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_PERILLA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_perillas`
--

LOCK TABLES `prod_perillas` WRITE;
/*!40000 ALTER TABLE `prod_perillas` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_perillas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_poleas`
--

DROP TABLE IF EXISTS `prod_poleas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_poleas` (
  `ID_POLEA` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(100) NOT NULL,
  `TIPO_CANAL` int(11) NOT NULL,
  `DIAMETRO` varchar(10) NOT NULL,
  `CANTIDAD_CANALES` int(11) NOT NULL,
  `UNIDADES` int(11) NOT NULL,
  `ACTIVO` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID_POLEA`),
  KEY `UNIDADES_POLEA` (`TIPO_CANAL`),
  CONSTRAINT `ID_POLEA` FOREIGN KEY (`ID_POLEA`) REFERENCES `prod_productos` (`ID_PRODUCTO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `UNIDADES_POLEA` FOREIGN KEY (`TIPO_CANAL`) REFERENCES `prod_tipo_canal` (`ID_TIPO_CANAL`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_poleas`
--

LOCK TABLES `prod_poleas` WRITE;
/*!40000 ALTER TABLE `prod_poleas` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_poleas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_productos`
--

DROP TABLE IF EXISTS `prod_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_productos` (
  `ID_PRODUCTO` int(11) NOT NULL,
  `DESCRIPCION` varchar(100) DEFAULT NULL,
  `ACTIVO` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID_PRODUCTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_productos`
--

LOCK TABLES `prod_productos` WRITE;
/*!40000 ALTER TABLE `prod_productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_tipo_canal`
--

DROP TABLE IF EXISTS `prod_tipo_canal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_tipo_canal` (
  `ID_TIPO_CANAL` int(11) NOT NULL,
  `NOMBRE` varchar(100) DEFAULT NULL,
  `DESCRIPCION` varchar(100) DEFAULT NULL,
  `ACTIVO` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_TIPO_CANAL`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_tipo_canal`
--

LOCK TABLES `prod_tipo_canal` WRITE;
/*!40000 ALTER TABLE `prod_tipo_canal` DISABLE KEYS */;
INSERT INTO `prod_tipo_canal` VALUES (1,'CANALFranco','HOLIS',1),(2,'CANALRodrigo','HOLIS x2',1),(3,'CANALJosias','HOLIS x3',1);
/*!40000 ALTER TABLE `prod_tipo_canal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_unidades`
--

DROP TABLE IF EXISTS `prod_unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_unidades` (
  `ID_UNIDAD` int(11) NOT NULL,
  `NOMBRE` varchar(100) NOT NULL,
  `DESCRIPCION` varchar(100) NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_UNIDAD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_unidades`
--

LOCK TABLES `prod_unidades` WRITE;
/*!40000 ALTER TABLE `prod_unidades` DISABLE KEYS */;
INSERT INTO `prod_unidades` VALUES (1,'Franco','HOLI',1),(2,'Rodrigo','HOLI x2',1),(3,'Josias','HOLI x3',1);
/*!40000 ALTER TABLE `prod_unidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prov_materia`
--

DROP TABLE IF EXISTS `prov_materia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prov_materia` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(25) DEFAULT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `id_user_registro` bigint(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prov_materia`
--

LOCK TABLES `prov_materia` WRITE;
/*!40000 ALTER TABLE `prov_materia` DISABLE KEYS */;
/*!40000 ALTER TABLE `prov_materia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prov_materia_compania`
--

DROP TABLE IF EXISTS `prov_materia_compania`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prov_materia_compania` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `id_materia` bigint(15) DEFAULT NULL,
  `id_compania` bigint(15) DEFAULT NULL,
  `cantidad` decimal(15,5) DEFAULT NULL,
  `monto` decimal(15,5) DEFAULT NULL,
  `id_user_compra` bigint(15) DEFAULT NULL,
  `fecha_compra` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prov_materia_compania`
--

LOCK TABLES `prov_materia_compania` WRITE;
/*!40000 ALTER TABLE `prov_materia_compania` DISABLE KEYS */;
/*!40000 ALTER TABLE `prov_materia_compania` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seg_usuario`
--

DROP TABLE IF EXISTS `seg_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seg_usuario` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `id_persona` bigint(15) NOT NULL,
  `estado` varchar(10) NOT NULL,
  `usuario` varchar(200) NOT NULL,
  `clave` varchar(80) NOT NULL,
  `id_user_registro` bigint(15) NOT NULL,
  `fecha_registro` datetime NOT NULL,
  `id_user_modificacion` bigint(15) DEFAULT NULL,
  `fecha_modificacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQUE_seg_usuario_1` (`usuario`),
  KEY `REL_2` (`id_persona`),
  CONSTRAINT `REL_2` FOREIGN KEY (`id_persona`) REFERENCES `gen_persona` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_usuario`
--

LOCK TABLES `seg_usuario` WRITE;
/*!40000 ALTER TABLE `seg_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `seg_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tran_produccion_almacenes`
--

DROP TABLE IF EXISTS `tran_produccion_almacenes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tran_produccion_almacenes` (
  `ID_TRANSACCION_PR_AL` int(11) NOT NULL,
  `ID_USUARIO_SOLICITA` int(11) NOT NULL,
  `ID_USUARIO_RESPUESTA` int(11) NOT NULL,
  `ID_AREA_ORIGEN` int(11) NOT NULL,
  `ID_AREA_DESTINO` int(11) NOT NULL,
  `ID_PRODUCTO` int(11) NOT NULL,
  `CANTIDAD` int(11) NOT NULL,
  `ID_UNIDAD` int(11) NOT NULL,
  `ID_ESTADO` int(11) NOT NULL,
  `FECHA_INICIO` date NOT NULL,
  `FECHA_FIN` date NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_TRANSACCION_PR_AL`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tran_produccion_almacenes`
--

LOCK TABLES `tran_produccion_almacenes` WRITE;
/*!40000 ALTER TABLE `tran_produccion_almacenes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tran_produccion_almacenes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trans_produccion_compras`
--

DROP TABLE IF EXISTS `trans_produccion_compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trans_produccion_compras` (
  `ID_TRANSACCION_PR_CO` int(11) NOT NULL,
  `ID_USUARIO_SOLICITA` int(11) NOT NULL,
  `ID_USUARIO_RESPUESTA` int(11) NOT NULL,
  `ID_AREA_ORIGEN` int(11) NOT NULL,
  `ID_AREA_DESTINO` int(11) NOT NULL,
  `ID_MATERIAL` int(11) NOT NULL,
  `CANTIDAD` decimal(10,4) NOT NULL,
  `ID_UNIDAD` int(11) NOT NULL,
  `ID_ESTADO` int(11) NOT NULL,
  `FECHA_INICIO` date NOT NULL,
  `FECHA_FIN` date NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_TRANSACCION_PR_CO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trans_produccion_compras`
--

LOCK TABLES `trans_produccion_compras` WRITE;
/*!40000 ALTER TABLE `trans_produccion_compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `trans_produccion_compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transac_produccion_almacen`
--

DROP TABLE IF EXISTS `transac_produccion_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transac_produccion_almacen` (
  `ID_LISTA_PRODUCCION` int(11) NOT NULL,
  `ID_PEDIDO` int(11) NOT NULL,
  `FECHA_TRANSACCION` date DEFAULT NULL,
  `ESTADO` int(11) DEFAULT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_LISTA_PRODUCCION`,`ID_PEDIDO`),
  KEY `ID_PEDIDO_TRANSAC_idx` (`ID_PEDIDO`),
  KEY `ESTADO_TRANSAC_idx` (`ESTADO`),
  CONSTRAINT `ID_LST_PROD` FOREIGN KEY (`ID_LISTA_PRODUCCION`) REFERENCES `prod_listas_produccion` (`ID_LISTA_PRODUCCION`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ID_PEDIDO_TRANSAC` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `al_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ESTADO_TRANSAC` FOREIGN KEY (`ESTADO`) REFERENCES `prod_estados` (`ID_ESTADO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transac_produccion_almacen`
--

LOCK TABLES `transac_produccion_almacen` WRITE;
/*!40000 ALTER TABLE `transac_produccion_almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `transac_produccion_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_cliente_juridico`
--

DROP TABLE IF EXISTS `ven_cliente_juridico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_cliente_juridico` (
  `ID_CLIENTE` int(5) NOT NULL AUTO_INCREMENT,
  `RAZON_SOCIAL` varchar(70) NOT NULL,
  `RUC` int(8) NOT NULL,
  `GIRO_NEGOCIO` varchar(20) NOT NULL,
  `DIRECCION` varchar(150) NOT NULL,
  `TELEFONO` int(8) NOT NULL,
  `CORREO` varchar(40) NOT NULL,
  `FECHA_REGISTRO` date NOT NULL,
  `USUARIO_REGISTRO` varchar(35) NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_cliente_juridico`
--

LOCK TABLES `ven_cliente_juridico` WRITE;
/*!40000 ALTER TABLE `ven_cliente_juridico` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_cliente_juridico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_cliente_natural`
--

DROP TABLE IF EXISTS `ven_cliente_natural`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_cliente_natural` (
  `ID_CLIENTE` int(5) NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(50) NOT NULL,
  `APELLIDO_P` varchar(25) NOT NULL,
  `APELLIDO_M` varchar(25) NOT NULL,
  `DNI` int(8) NOT NULL,
  `SEXO` tinyint(1) NOT NULL,
  `DIRECCION` varchar(150) NOT NULL,
  `TELEFONO` int(10) NOT NULL,
  `CORREO` varchar(35) NOT NULL,
  `FECHA_REGISTRO` date NOT NULL,
  `USUARIO_REGISTRO` varchar(30) NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`),
  KEY `ID_CLIENTE` (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_cliente_natural`
--

LOCK TABLES `ven_cliente_natural` WRITE;
/*!40000 ALTER TABLE `ven_cliente_natural` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_cliente_natural` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_linea_pedido_almacen`
--

DROP TABLE IF EXISTS `ven_linea_pedido_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_linea_pedido_almacen` (
  `ID_LINEA` int(5) NOT NULL AUTO_INCREMENT,
  `ID_VENTA` int(5) NOT NULL,
  `ID_PRODUCTO` int(5) NOT NULL,
  `CANTIDAD` int(5) NOT NULL,
  PRIMARY KEY (`ID_LINEA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_linea_pedido_almacen`
--

LOCK TABLES `ven_linea_pedido_almacen` WRITE;
/*!40000 ALTER TABLE `ven_linea_pedido_almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_linea_pedido_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_linea_venta`
--

DROP TABLE IF EXISTS `ven_linea_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_linea_venta` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `id_venta` bigint(15) DEFAULT NULL,
  `id_producto` bigint(15) DEFAULT NULL,
  `cantidad` int(15) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_7` (`id_venta`),
  CONSTRAINT `REL_7` FOREIGN KEY (`id_venta`) REFERENCES `ven_ventas` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_linea_venta`
--

LOCK TABLES `ven_linea_venta` WRITE;
/*!40000 ALTER TABLE `ven_linea_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_linea_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_pedido_almacen`
--

DROP TABLE IF EXISTS `ven_pedido_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_pedido_almacen` (
  `ID_PEDIDO` int(5) NOT NULL AUTO_INCREMENT,
  `ID_VENTA` int(5) NOT NULL,
  `ESTADO` text NOT NULL,
  `FECHA_REGISTRO` date NOT NULL,
  `USUARIO_REGISTRO` varchar(30) NOT NULL,
  `ACTIVO` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_PEDIDO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_pedido_almacen`
--

LOCK TABLES `ven_pedido_almacen` WRITE;
/*!40000 ALTER TABLE `ven_pedido_almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_pedido_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_ventas`
--

DROP TABLE IF EXISTS `ven_ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_ventas` (
  `id` bigint(15) NOT NULL AUTO_INCREMENT,
  `id_cliente` bigint(15) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `descuento` decimal(15,5) DEFAULT NULL,
  `id_concepto_descuento` varchar(25) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_registro` bigint(15) DEFAULT NULL,
  `es_activo` bigint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_ventas`
--

LOCK TABLES `ven_ventas` WRITE;
/*!40000 ALTER TABLE `ven_ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'inf282g2'
--

--
-- Dumping routines for database 'inf282g2'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-24  3:16:31
