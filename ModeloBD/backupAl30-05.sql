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
-- Table structure for table `alm_almacen`
--

DROP TABLE IF EXISTS `alm_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_almacen` (
  `idAlmacen` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(256) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `habilitado` tinyint(4) NOT NULL,
  `fk_idArea` int(11) NOT NULL,
  PRIMARY KEY (`idAlmacen`),
  KEY `fk_idArea_idx` (`fk_idArea`),
  CONSTRAINT `fk_idArea` FOREIGN KEY (`fk_idArea`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_almacen`
--

LOCK TABLES `alm_almacen` WRITE;
/*!40000 ALTER TABLE `alm_almacen` DISABLE KEYS */;
INSERT INTO `alm_almacen` VALUES (1,'Direccion del almacen 1','111-1111',1,1),(2,'Direccion del almacen 2','222-2222',1,1),(3,'Direccion del almacen 3','333-3333',1,1),(4,'Direccion del almacen 4','444-4444',1,1),(5,'Direccion del almacen 5','555-5555',1,1);
/*!40000 ALTER TABLE `alm_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_detalle_ingresos`
--

DROP TABLE IF EXISTS `alm_detalle_ingresos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_detalle_ingresos` (
  `id_movimiento` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `id_area_origen` int(11) NOT NULL,
  `id_sede_origen` int(11) NOT NULL,
  `id_area_destino` int(11) NOT NULL,
  `id_sede_destino` int(11) NOT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `id_producto_ingresos` (`id_producto`),
  KEY `area_origen_ingresos` (`id_area_origen`),
  KEY `area_destino_ingresos` (`id_area_destino`),
  CONSTRAINT `area_destino_ingresos` FOREIGN KEY (`id_area_destino`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `area_origen_ingresos` FOREIGN KEY (`id_area_origen`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_producto_ingresos` FOREIGN KEY (`id_producto`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `movimiento_ingresos` FOREIGN KEY (`id_movimiento`) REFERENCES `alm_ingresos_y_salidas` (`id_movimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_detalle_ingresos`
--

LOCK TABLES `alm_detalle_ingresos` WRITE;
/*!40000 ALTER TABLE `alm_detalle_ingresos` DISABLE KEYS */;
/*!40000 ALTER TABLE `alm_detalle_ingresos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_detalle_salidas`
--

DROP TABLE IF EXISTS `alm_detalle_salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_detalle_salidas` (
  `id_movimiento` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `id_area_origen` int(11) NOT NULL,
  `id_sede_origen` int(11) NOT NULL,
  `id_area_destino` int(11) NOT NULL,
  `id_sede_destino` int(11) NOT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `id_producto_salidas_idx` (`id_producto`),
  KEY `area_origen_salidas_idx` (`id_area_destino`),
  KEY `area_origen_salidas` (`id_area_origen`),
  CONSTRAINT `area_destino_salidas` FOREIGN KEY (`id_area_destino`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `area_origen_salidas` FOREIGN KEY (`id_area_origen`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `movimiento_salidas` FOREIGN KEY (`id_movimiento`) REFERENCES `alm_ingresos_y_salidas` (`id_movimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_producto_salidas` FOREIGN KEY (`id_producto`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_detalle_salidas`
--

LOCK TABLES `alm_detalle_salidas` WRITE;
/*!40000 ALTER TABLE `alm_detalle_salidas` DISABLE KEYS */;
/*!40000 ALTER TABLE `alm_detalle_salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_ingreso_producto`
--

DROP TABLE IF EXISTS `alm_ingreso_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_ingreso_producto` (
  `idIngresoProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Almacen_idAlmacen` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  `idLocalEmisor` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`idIngresoProducto`),
  KEY `fk_IngresoProducto_Almacen1_idx` (`Almacen_idAlmacen`),
  KEY `fk_ALM_INGRESO_PRODUCTO_LOCAL1_idx` (`idLocalEmisor`),
  CONSTRAINT `fk_ALM_INGRESO_PRODUCTO_LOCAL1` FOREIGN KEY (`idLocalEmisor`) REFERENCES `alm_local` (`idLOCAL`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_IngresoProducto_Almacen1` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `alm_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_ingreso_producto`
--

LOCK TABLES `alm_ingreso_producto` WRITE;
/*!40000 ALTER TABLE `alm_ingreso_producto` DISABLE KEYS */;
INSERT INTO `alm_ingreso_producto` VALUES (1,1,'2018-05-24 02:05:20',3,'Primer Ingreso'),(2,1,'2018-05-24 02:19:27',3,'OK. Se recupera todo'),(3,1,'2018-05-24 02:27:58',3,'OK'),(4,1,'2018-05-24 02:29:18',1,''),(5,1,'2018-05-24 03:28:06',1,''),(6,1,'2018-05-24 11:39:37',1,''),(7,1,'2018-05-24 11:40:21',3,''),(8,1,'2018-05-26 03:41:58',1,'Prueba');
/*!40000 ALTER TABLE `alm_ingreso_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_ingresos_y_salidas`
--

DROP TABLE IF EXISTS `alm_ingresos_y_salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_ingresos_y_salidas` (
  `id_movimiento` int(11) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `habilitado` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_movimiento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_ingresos_y_salidas`
--

LOCK TABLES `alm_ingresos_y_salidas` WRITE;
/*!40000 ALTER TABLE `alm_ingresos_y_salidas` DISABLE KEYS */;
/*!40000 ALTER TABLE `alm_ingresos_y_salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_linea_ingreso_producto`
--

DROP TABLE IF EXISTS `alm_linea_ingreso_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_linea_ingreso_producto` (
  `idLineaIngresoProducto` int(11) NOT NULL AUTO_INCREMENT,
  `IngresoProducto_idIngresoProducto` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `cantidadIngreso` int(11) NOT NULL,
  `observaciones` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idLineaIngresoProducto`),
  KEY `fk_ALM_LINEA_INGRESO_PRODUCTO_IngresoProducto1_idx` (`IngresoProducto_idIngresoProducto`),
  KEY `fk_ALM_LINEA_INGRESO_PRODUCTO_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_ALM_LINEA_INGRESO_PRODUCTO_IngresoProducto1` FOREIGN KEY (`IngresoProducto_idIngresoProducto`) REFERENCES `alm_ingreso_producto` (`idIngresoProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ALM_LINEA_INGRESO_PRODUCTO_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_linea_ingreso_producto`
--

LOCK TABLES `alm_linea_ingreso_producto` WRITE;
/*!40000 ALTER TABLE `alm_linea_ingreso_producto` DISABLE KEYS */;
INSERT INTO `alm_linea_ingreso_producto` VALUES (2,1,1,10,'1'),(3,1,4,40,'2'),(4,3,1,5,''),(5,3,4,10,''),(6,4,1,1,''),(7,7,6,20,''),(8,7,12,12,''),(9,8,1,10,'Prueba');
/*!40000 ALTER TABLE `alm_linea_ingreso_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_linea_salida_producto`
--

DROP TABLE IF EXISTS `alm_linea_salida_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_linea_salida_producto` (
  `idLineaSalidaProducto` int(11) NOT NULL AUTO_INCREMENT,
  `SalidaProducto_idSalidaProducto` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `cantidadSalida` int(11) NOT NULL,
  `observaciones` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idLineaSalidaProducto`),
  KEY `fk_ALM_LINEA_SALIDA_PRODUCTO_SalidaProducto1_idx` (`SalidaProducto_idSalidaProducto`),
  KEY `fk_ALM_LINEA_SALIDA_PRODUCTO_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_ALM_LINEA_SALIDA_PRODUCTO_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ALM_LINEA_SALIDA_PRODUCTO_SalidaProducto1` FOREIGN KEY (`SalidaProducto_idSalidaProducto`) REFERENCES `alm_salida_producto` (`idSalidaProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_linea_salida_producto`
--

LOCK TABLES `alm_linea_salida_producto` WRITE;
/*!40000 ALTER TABLE `alm_linea_salida_producto` DISABLE KEYS */;
INSERT INTO `alm_linea_salida_producto` VALUES (8,21,1,5,'Te mando la mitad'),(9,21,4,10,'Te mando 10'),(10,22,1,1,''),(11,23,1,5,''),(12,23,4,10,''),(13,24,6,30,''),(14,24,12,42,'');
/*!40000 ALTER TABLE `alm_linea_salida_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_local`
--

DROP TABLE IF EXISTS `alm_local`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_local` (
  `idLOCAL` int(11) NOT NULL AUTO_INCREMENT,
  `telefonoLOCAL` varchar(15) NOT NULL,
  `direccionLOCAL` varchar(128) NOT NULL,
  PRIMARY KEY (`idLOCAL`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_local`
--

LOCK TABLES `alm_local` WRITE;
/*!40000 ALTER TABLE `alm_local` DISABLE KEYS */;
INSERT INTO `alm_local` VALUES (1,'111-1111','Direccion del local1'),(2,'222-2222','Direccion del local 2'),(3,'333-3333','Direccion del local 3'),(4,'444444444','Direccion del local 4'),(5,'555555555','Direccion del local 4');
/*!40000 ALTER TABLE `alm_local` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_pedido_a_produccion`
--

DROP TABLE IF EXISTS `alm_pedido_a_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_pedido_a_produccion` (
  `ID_PEDIDO` int(11) NOT NULL,
  `ID_PRODUCTO` int(11) NOT NULL,
  `CANTIDAD` int(11) NOT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_PEDIDO`,`ID_PRODUCTO`),
  CONSTRAINT `ID_PRODUCTO` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `prod_productos` (`ID_PRODUCTO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_pedido_a_produccion`
--

LOCK TABLES `alm_pedido_a_produccion` WRITE;
/*!40000 ALTER TABLE `alm_pedido_a_produccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `alm_pedido_a_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_producto_almacen`
--

DROP TABLE IF EXISTS `alm_producto_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_producto_almacen` (
  `Almacen_idAlmacen` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `cantidadAlmacenada` int(11) NOT NULL,
  KEY `fk_ProductoAlmacen_Almacen` (`Almacen_idAlmacen`),
  KEY `fk_idProducto_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_idProducto` FOREIGN KEY (`Producto_idProducto`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProductoAlmacen_Almacen` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `alm_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_producto_almacen`
--

LOCK TABLES `alm_producto_almacen` WRITE;
/*!40000 ALTER TABLE `alm_producto_almacen` DISABLE KEYS */;
INSERT INTO `alm_producto_almacen` VALUES (1,1,20),(3,2,20),(2,3,24),(1,4,40),(4,4,44),(1,6,5),(3,6,25),(3,7,10);
/*!40000 ALTER TABLE `alm_producto_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_salida_producto`
--

DROP TABLE IF EXISTS `alm_salida_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_salida_producto` (
  `idSalidaProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Almacen_idAlmacen` int(11) NOT NULL,
  `fechaSalida` datetime NOT NULL,
  `idLocalDestino` int(11) DEFAULT NULL,
  `estadoEnvio` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`idSalidaProducto`),
  KEY `fk_SalidaProducto_Almacen1_idx` (`Almacen_idAlmacen`),
  KEY `fk_ALM_SALIDA_PRODUCTO_LOCAL1_idx` (`idLocalDestino`),
  CONSTRAINT `fk_SalidaProducto_Almacen1` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `alm_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_salida_producto`
--

LOCK TABLES `alm_salida_producto` WRITE;
/*!40000 ALTER TABLE `alm_salida_producto` DISABLE KEYS */;
INSERT INTO `alm_salida_producto` VALUES (21,1,'2018-05-24 02:18:19',2,1,'OK'),(22,1,'2018-05-24 02:29:51',1,1,''),(23,1,'2018-05-24 03:29:19',3,1,''),(24,1,'2018-05-24 11:41:09',2,1,'');
/*!40000 ALTER TABLE `alm_salida_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gen_areas`
--

DROP TABLE IF EXISTS `gen_areas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_areas` (
  `id_area` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `fecha_creacion` datetime NOT NULL,
  `fecha_modificacion` datetime NOT NULL,
  `habilitado` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_area`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_areas`
--

LOCK TABLES `gen_areas` WRITE;
/*!40000 ALTER TABLE `gen_areas` DISABLE KEYS */;
INSERT INTO `gen_areas` VALUES (1,'Almacen','2018-05-30 00:00:00','2018-05-30 00:00:00',1);
/*!40000 ALTER TABLE `gen_areas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gen_compania`
--

DROP TABLE IF EXISTS `gen_compania`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_compania` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `id_persona_representa` int(15) DEFAULT NULL,
  `ruc` varchar(20) DEFAULT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `id_pais` int(15) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_5` (`id_persona_representa`),
  CONSTRAINT `REL_5` FOREIGN KEY (`id_persona_representa`) REFERENCES `gen_persona` (`id`)
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
-- Table structure for table `gen_persona`
--

DROP TABLE IF EXISTS `gen_persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gen_persona` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(100) DEFAULT NULL,
  `paterno` varchar(50) NOT NULL,
  `materno` varchar(50) DEFAULT NULL,
  `primer_nombre` varchar(50) DEFAULT NULL,
  `segundo_nombre` varchar(50) DEFAULT NULL,
  `sexo` varchar(1) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `id_tipo_doc_identidad` int(15) NOT NULL,
  `numero_doc_identidad` varchar(25) NOT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `estado` varchar(3) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_modificaci?n` int(15) DEFAULT NULL,
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
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(30) DEFAULT NULL,
  `nombre` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
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
  CONSTRAINT `ID_PED` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `alm_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
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
  `id_estado` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_estado`)
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
  CONSTRAINT `ID_PEDIDO ` FOREIGN KEY (`ID_LISTA_PRODUCCION`) REFERENCES `alm_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ESTADO ` FOREIGN KEY (`ESTADO`) REFERENCES `prod_estados` (`id_estado`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  `id_manivela` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `diametro` varchar(10) NOT NULL,
  `id_unidad` int(11) NOT NULL,
  PRIMARY KEY (`id_manivela`),
  KEY `unidades_manivela_idx` (`id_unidad`),
  CONSTRAINT `id_manivela` FOREIGN KEY (`id_manivela`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidades_manivela` FOREIGN KEY (`id_unidad`) REFERENCES `prod_unidades` (`ID_UNIDAD`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  `id_perilla` int(11) NOT NULL,
  `diametro` varchar(10) NOT NULL,
  `longitud` varchar(10) NOT NULL,
  `id_unidad` int(11) NOT NULL,
  PRIMARY KEY (`id_perilla`),
  KEY `unidades_perilla_idx` (`id_unidad`),
  CONSTRAINT `id_perilla` FOREIGN KEY (`id_perilla`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidades_perilla` FOREIGN KEY (`id_unidad`) REFERENCES `prod_unidades` (`ID_UNIDAD`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  `id_polea` int(11) NOT NULL,
  `tipo_canal` int(11) NOT NULL,
  `diametro` varchar(10) NOT NULL,
  `id_unidad` int(11) NOT NULL,
  `cantidad_canales` int(11) NOT NULL,
  PRIMARY KEY (`id_polea`),
  KEY `tipo_canal_polea` (`tipo_canal`),
  KEY `unidades_polea_idx` (`id_unidad`),
  CONSTRAINT `id_polea` FOREIGN KEY (`id_polea`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tipo_canal_polea` FOREIGN KEY (`tipo_canal`) REFERENCES `prod_tipos_canales` (`ID_TIPO_CANAL`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidades_polea` FOREIGN KEY (`id_unidad`) REFERENCES `prod_unidades` (`ID_UNIDAD`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `id_tipo_producto` int(11) NOT NULL,
  `codigo_producto` varchar(10) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_venta` double NOT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `fecha_modificacion` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `activo` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `id_tipo_producto_idx` (`id_tipo_producto`),
  CONSTRAINT `id_tipo_producto` FOREIGN KEY (`id_tipo_producto`) REFERENCES `prod_tipos_productos` (`id_tipo_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_productos`
--

LOCK TABLES `prod_productos` WRITE;
/*!40000 ALTER TABLE `prod_productos` DISABLE KEYS */;
INSERT INTO `prod_productos` VALUES (1,1,'POL01','Producto 1','Polea 1',10,'2018-05-30 13:23:07','2018-05-30 13:23:07',1),(2,1,'POL02','Producto 2','Polea 2',20,'2018-05-30 13:23:07','2018-05-30 13:23:07',1),(3,1,'POL03','Producto 3','Polea 3',30,'2018-05-30 13:23:07','2018-05-30 13:23:07',1),(4,3,'PER01','Producto 4','Perilla 1',40,'2018-05-30 13:23:07','2018-05-30 13:23:07',1),(5,3,'PER02','Producto 5','Perilla 2',50,'2018-05-30 13:23:07','2018-05-30 13:23:07',1),(6,3,'PER03','Producto 6','Perilla 3',30,'2018-05-30 13:23:07','2018-05-30 13:23:07',1),(7,3,'PER04','Producto 7','Perilla 4',35,'2018-05-30 13:23:07','2018-05-30 13:23:07',1);
/*!40000 ALTER TABLE `prod_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_tipos_canales`
--

DROP TABLE IF EXISTS `prod_tipos_canales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_tipos_canales` (
  `id_tipo_canal` int(11) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_canal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_tipos_canales`
--

LOCK TABLES `prod_tipos_canales` WRITE;
/*!40000 ALTER TABLE `prod_tipos_canales` DISABLE KEYS */;
INSERT INTO `prod_tipos_canales` VALUES (1,'CANALFranco','HOLIS',1),(2,'CANALRodrigo','HOLIS x2',1),(3,'CANALJosias','HOLIS x3',1);
/*!40000 ALTER TABLE `prod_tipos_canales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_tipos_productos`
--

DROP TABLE IF EXISTS `prod_tipos_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_tipos_productos` (
  `id_tipo_producto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `activo` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_tipo_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_tipos_productos`
--

LOCK TABLES `prod_tipos_productos` WRITE;
/*!40000 ALTER TABLE `prod_tipos_productos` DISABLE KEYS */;
INSERT INTO `prod_tipos_productos` VALUES (1,'POLEA',NULL,1),(2,'MANIVELA',NULL,1),(3,'PERILLA',NULL,1);
/*!40000 ALTER TABLE `prod_tipos_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_unidades`
--

DROP TABLE IF EXISTS `prod_unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_unidades` (
  `id_unidad` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_unidad`)
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
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `codProducto` varchar(10) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcionProd` varchar(100) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `habilitado` tinyint(4) NOT NULL,
  PRIMARY KEY (`idProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Prod1','Producto 1','Polea 1',10,1),(2,'Prod2','Producto 2','Polea 2',20,1),(3,'Prod3','Producto 3','Polea 3',30,1),(4,'Prod4','Producto 4','Cadena 1',40,1),(5,'Prod5','Producto 5','Cadena 2',50,1),(6,'Per1','Perilla Marca X','Perilla de 15\"',15,1),(7,'Per2','Perilla Marca X','Perilla de 20\"',20,1),(8,'Per3','Perilla Marca X Deluxe','Perilla de 15\"',30,1),(9,'Per3','Perilla Marca X Extra','Perilla de 15\"',25,1),(10,'Per4','Perilla Marca X Extra','Perilla de 20\"',30,1),(11,'Per5','Perilla Marca X Deluxe','Perilla de 20\"',40,1),(12,'Maniv1','Manivela Marca M','Manivela 10\"',15,1),(13,'Maniv2','Manivala Marca M','Manivela 15\"',20,1);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
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
-- Table structure for table `seg_rol`
--

DROP TABLE IF EXISTS `seg_rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seg_rol` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_rol`
--

LOCK TABLES `seg_rol` WRITE;
/*!40000 ALTER TABLE `seg_rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `seg_rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seg_usuario`
--

DROP TABLE IF EXISTS `seg_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seg_usuario` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `id_persona` int(15) NOT NULL,
  `usuario` varchar(200) NOT NULL,
  `clave` varchar(80) NOT NULL,
  `estado` varchar(3) NOT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_modificacion` int(15) DEFAULT NULL,
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
-- Table structure for table `seg_usuario_rol`
--

DROP TABLE IF EXISTS `seg_usuario_rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seg_usuario_rol` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `id_usuario` int(15) NOT NULL,
  `id_rol` int(15) NOT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_3` (`id_rol`),
  KEY `REL_4` (`id_usuario`),
  CONSTRAINT `REL_4` FOREIGN KEY (`id_usuario`) REFERENCES `seg_usuario` (`id`),
  CONSTRAINT `REL_3` FOREIGN KEY (`id_rol`) REFERENCES `seg_rol` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_usuario_rol`
--

LOCK TABLES `seg_usuario_rol` WRITE;
/*!40000 ALTER TABLE `seg_usuario_rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `seg_usuario_rol` ENABLE KEYS */;
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
  CONSTRAINT `ID_PEDIDO_TRANSAC` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `alm_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ESTADO_TRANSAC` FOREIGN KEY (`ESTADO`) REFERENCES `prod_estados` (`id_estado`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_cliente_juridico`
--

LOCK TABLES `ven_cliente_juridico` WRITE;
/*!40000 ALTER TABLE `ven_cliente_juridico` DISABLE KEYS */;
INSERT INTO `ven_cliente_juridico` VALUES (1,'Multiservicio Industrial y Automotriz S.A.',94949412,'Servicios Mecanicos','Av. Guardia Civil 432',4219411,'ventas@mindasa.com','2018-05-24','admin',1),(2,'Frenos Panchito',12345678,'Servicios Mecanicos','Av. Los Ingenieros 991',987654321,'fake_corporativo@email.com','2018-05-24','admin',1),(3,'Mecanica El Paw',94317413,'Mecanica','Av. el Paw 231',984134143,'paw@paw.com','2018-05-24','admin',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_cliente_natural`
--

LOCK TABLES `ven_cliente_natural` WRITE;
/*!40000 ALTER TABLE `ven_cliente_natural` DISABLE KEYS */;
INSERT INTO `ven_cliente_natural` VALUES (1,'Carlos','Torrico','Menendez',79481293,1,'Av. Los Fresnos 342',948517328,'fake@email.com','2018-05-24','admin',1),(2,'Daniela','Torrico','Menendez',79481293,0,'Av. Los Fresnos 342',948517328,'fake2@email.com','2018-05-24','admin',1),(3,'Danilo','Marticorena','Jimenez',49302819,1,'Av. Las Acacias 666',984758373,'fake3@email.com','2018-05-24','admin',1),(6,'Carlos Quispe Quispe','Quispe','Quispe',71255555,1,'Av. San Luis 222',968686562,'a@a.com','2018-05-24','admin',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_ventas`
--

LOCK TABLES `ven_ventas` WRITE;
/*!40000 ALTER TABLE `ven_ventas` DISABLE KEYS */;
INSERT INTO `ven_ventas` VALUES (1,2,'Aprobada',0.15000,'Cliente frecuente','2018-05-24 00:00:00',0,1);
/*!40000 ALTER TABLE `ven_ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'inf282g2'
--

--
-- Dumping routines for database 'inf282g2'
--
/*!50003 DROP PROCEDURE IF EXISTS `alm_actualizar_stock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_actualizar_stock`(
	_idAlmacen  INT,
	_idProducto INT,
    _nuevoStock INT
)
BEGIN
	UPDATE alm_producto_almacen
    SET cantidadAlmacenada = _nuevoStock
    WHERE Almacen_idAlmacen = _idAlmacen AND
		Producto_idProducto = _idProducto;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_obtenerAlmacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_obtenerAlmacen`(_idAlmacen int)
BEGIN
	SELECT * FROM alm_almacen WHERE idAlmacen = _idAlmacen;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_producto_almacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_producto_almacen`(
	_idProducto INT,
    _idAlmacen INT,
    _stockInicial INT
)
BEGIN
	INSERT INTO alm_producto_almacen (Almacen_idAlmacen,Producto_idProducto,cantidadAlmacenada)
    VALUES (_idAlmacen,_idProducto,_stockInicial);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_almacenes_habilitados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_almacenes_habilitados`()
BEGIN
	SELECT * FROM alm_almacen WHERE habilitado = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_almacenes_todos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_almacenes_todos`()
BEGIN
	SELECT * FROM alm_almacen;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_productos_almacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_productos_almacen`(_idAlmacen int)
BEGIN
	SELECT id_producto,codigo_producto,nombre,descripcion,precio_venta,cantidadAlmacenada
	FROM alm_producto_almacen INNER JOIN prod_productos ON Producto_idProducto = id_producto
	WHERE Almacen_idAlmacen = _idAlmacen;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_productos_habilitados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_productos_habilitados`()
BEGIN
	SELECT * FROM prod_productos WHERE activo = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_productos_todos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_productos_todos`()
BEGIN
	SELECT * FROM prod_productos;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-30  4:21:21
