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
  CONSTRAINT `fk_ALM_LINEA_INGRESO_PRODUCTO_IngresoProducto1` FOREIGN KEY (`IngresoProducto_idIngresoProducto`) REFERENCES `alm_ingreso_producto` (`idIngresoProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
-- Table structure for table `alm_usuario_almacen`
--

DROP TABLE IF EXISTS `alm_usuario_almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_usuario_almacen` (
  `idAlmacen` int(11) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `habilitado` tinyint(4) NOT NULL,
  PRIMARY KEY (`idAlmacen`,`idUsuario`),
  KEY `fk_idUsuario_idx` (`idUsuario`),
  CONSTRAINT `fk_idAlmacen` FOREIGN KEY (`idAlmacen`) REFERENCES `alm_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_idUsuario` FOREIGN KEY (`idUsuario`) REFERENCES `seg_usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_usuario_almacen`
--

LOCK TABLES `alm_usuario_almacen` WRITE;
/*!40000 ALTER TABLE `alm_usuario_almacen` DISABLE KEYS */;
INSERT INTO `alm_usuario_almacen` VALUES (1,5,1),(2,5,1);
/*!40000 ALTER TABLE `alm_usuario_almacen` ENABLE KEYS */;
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
  `id_user_modificacion` int(15) DEFAULT NULL,
  `fecha_moficacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQUE_Persona_1` (`numero_doc_identidad`,`email`),
  KEY `REL_1` (`id_tipo_doc_identidad`),
  CONSTRAINT `REL_1` FOREIGN KEY (`id_tipo_doc_identidad`) REFERENCES `gen_tipo_doc_identidad` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_persona`
--

LOCK TABLES `gen_persona` WRITE;
/*!40000 ALTER TABLE `gen_persona` DISABLE KEYS */;
INSERT INTO `gen_persona` VALUES (1,'Bruno','Espezúa','',NULL,NULL,'M','bruno.espezua@pucp.pe',NULL,NULL,1,'77591264',NULL,NULL,NULL,NULL,NULL,NULL),(2,'Franco','Pariasca',NULL,NULL,NULL,'M','correo de franco',NULL,NULL,1,'DNI de Franco',NULL,NULL,NULL,NULL,NULL,NULL),(3,'Rodrigo','Suarez',NULL,NULL,NULL,'M','correo de rodrigo',NULL,NULL,1,'DNI de Rodrigo',NULL,NULL,NULL,NULL,NULL,NULL),(4,'Josias','Carhuas','Ospina',NULL,NULL,'M','jcarhuasp@gmail.com',NULL,NULL,1,'47059190',NULL,NULL,NULL,NULL,NULL,NULL),(5,'Harleen','Viguria',NULL,NULL,NULL,'M','correo de Harleen',NULL,NULL,1,'DNI de Harleen',NULL,NULL,NULL,NULL,NULL,NULL),(6,'Paulo','Tuya',NULL,NULL,NULL,'M','correo de Paulo',NULL,NULL,1,'DNI de Paulo',NULL,NULL,NULL,NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_tipo_doc_identidad`
--

LOCK TABLES `gen_tipo_doc_identidad` WRITE;
/*!40000 ALTER TABLE `gen_tipo_doc_identidad` DISABLE KEYS */;
INSERT INTO `gen_tipo_doc_identidad` VALUES (1,'DNI','Documento Nacional de Identidad');
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
  `id_estado` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
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
  `diametro` varchar(10) NOT NULL,
  `id_unidad_manivela` int(11) NOT NULL,
  PRIMARY KEY (`id_manivela`),
  KEY `unidad_manivela_idx` (`id_unidad_manivela`),
  CONSTRAINT `id_manivela` FOREIGN KEY (`id_manivela`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidad_manivela` FOREIGN KEY (`id_unidad_manivela`) REFERENCES `prod_unidades_productos` (`id_unidad_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_manivelas`
--

LOCK TABLES `prod_manivelas` WRITE;
/*!40000 ALTER TABLE `prod_manivelas` DISABLE KEYS */;
INSERT INTO `prod_manivelas` VALUES (7,'34.24',1),(8,'8/5',1),(9,'13/5',1);
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
  `id_unidad_perilla` int(11) NOT NULL,
  PRIMARY KEY (`id_perilla`),
  KEY `unidad_perilla_idx` (`id_unidad_perilla`),
  CONSTRAINT `unidad_perilla` FOREIGN KEY (`id_unidad_perilla`) REFERENCES `prod_unidades_productos` (`id_unidad_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_perilla` FOREIGN KEY (`id_perilla`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_perillas`
--

LOCK TABLES `prod_perillas` WRITE;
/*!40000 ALTER TABLE `prod_perillas` DISABLE KEYS */;
INSERT INTO `prod_perillas` VALUES (3,'3/8','3/81',1),(4,'5/8','5/81',1);
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
  `id_tipo_canal` int(11) NOT NULL,
  `diametro` varchar(10) NOT NULL,
  `id_unidad_polea` int(11) NOT NULL,
  `cantidad_canales` int(11) NOT NULL,
  PRIMARY KEY (`id_polea`),
  KEY `unidad_polea_idx` (`id_unidad_polea`),
  KEY `id_tipo_canal_polea` (`id_tipo_canal`),
  CONSTRAINT `id_tipo_canal_polea` FOREIGN KEY (`id_tipo_canal`) REFERENCES `prod_tipos_canales` (`id_tipo_canal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_polea` FOREIGN KEY (`id_polea`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidad_polea` FOREIGN KEY (`id_unidad_polea`) REFERENCES `prod_unidades_productos` (`id_unidad_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_poleas`
--

LOCK TABLES `prod_poleas` WRITE;
/*!40000 ALTER TABLE `prod_poleas` DISABLE KEYS */;
INSERT INTO `prod_poleas` VALUES (1,1,'3/80',1,2),(2,1,'5/8',1,2);
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
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_venta` decimal(10,2) NOT NULL,
  `id_unidad_monetaria` int(11) NOT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `fecha_modificacion` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `activo` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `id_tipo_producto_idx` (`id_tipo_producto`),
  KEY `unidad_monetaria_producto_idx` (`id_unidad_monetaria`),
  CONSTRAINT `id_tipo_producto` FOREIGN KEY (`id_tipo_producto`) REFERENCES `prod_tipos_productos` (`id_tipo_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidad_monetaria_producto` FOREIGN KEY (`id_unidad_monetaria`) REFERENCES `prod_unidades_monetarias` (`id_unidad_monetaria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_productos`
--

LOCK TABLES `prod_productos` WRITE;
/*!40000 ALTER TABLE `prod_productos` DISABLE KEYS */;
INSERT INTO `prod_productos` VALUES (1,1,'Polea de 3/80',NULL,87.65,4,'2018-05-31 00:11:59','2018-05-31 00:56:25',0),(2,1,'Polea 5/8','Es una polea de 5/8',35.12,1,'2018-05-31 00:12:54','2018-05-31 07:48:37',1),(3,1,'Perilla 3/8','Es una perilla de 3/8',45.87,1,'2018-05-31 05:22:21','2018-05-31 05:42:57',1),(4,1,'Perilla 5/8',NULL,54.63,1,'2018-05-31 05:24:14','2018-05-31 05:46:59',0),(5,1,'','5/2',34.24,3,'2018-05-31 06:45:16','2018-05-31 07:01:38',0),(6,1,'','5/2',34.24,3,'2018-05-31 06:45:40','2018-05-31 07:01:30',0),(7,1,'','5/2',34.24,3,'2018-05-31 06:45:54','2018-05-31 07:01:13',0),(8,1,'Manivela 8/5','Es una manivela de 8/5',54.80,2,'2018-05-31 06:47:52','2018-05-31 06:57:02',1),(9,1,'Manivela 13/5',NULL,87.50,4,'2018-05-31 06:48:55','2018-05-31 07:01:46',0);
/*!40000 ALTER TABLE `prod_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_tipos_canales`
--

DROP TABLE IF EXISTS `prod_tipos_canales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_tipos_canales` (
  `id_tipo_canal` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_canal`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
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
-- Table structure for table `prod_unidades_monetarias`
--

DROP TABLE IF EXISTS `prod_unidades_monetarias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_unidades_monetarias` (
  `id_unidad_monetaria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `activo` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_unidad_monetaria`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_unidades_monetarias`
--

LOCK TABLES `prod_unidades_monetarias` WRITE;
/*!40000 ALTER TABLE `prod_unidades_monetarias` DISABLE KEYS */;
INSERT INTO `prod_unidades_monetarias` VALUES (1,'SOLES','Valoracion de la moneda en Soles',1),(2,'DOLARES','Valoracion de la moneda en Dolares',1),(3,'EUROS','Valoracion de la moneda en Euros',1),(4,'YENES','Valoracion de la moneda en Yenes',1);
/*!40000 ALTER TABLE `prod_unidades_monetarias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_unidades_productos`
--

DROP TABLE IF EXISTS `prod_unidades_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_unidades_productos` (
  `id_unidad_producto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_unidad_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_unidades_productos`
--

LOCK TABLES `prod_unidades_productos` WRITE;
/*!40000 ALTER TABLE `prod_unidades_productos` DISABLE KEYS */;
INSERT INTO `prod_unidades_productos` VALUES (1,'HOLA','HOLA 2',1);
/*!40000 ALTER TABLE `prod_unidades_productos` ENABLE KEYS */;
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
  `codigo` varchar(10) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_rol`
--

LOCK TABLES `seg_rol` WRITE;
/*!40000 ALTER TABLE `seg_rol` DISABLE KEYS */;
INSERT INTO `seg_rol` VALUES (1,'Jefe de Ventas','JVEN','2018-05-30 20:35:42'),(2,'Jefe de Almacenes','JALM','2018-05-30 20:35:42'),(3,'Jefe de Producción','JPROD','2018-05-30 20:35:42'),(4,'Jefe de Compras Y Proveedores','JCPROV','2018-05-30 20:35:42'),(5,'Usuario de Almacen','UALM','2018-05-30 15:51:42');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_usuario`
--

LOCK TABLES `seg_usuario` WRITE;
/*!40000 ALTER TABLE `seg_usuario` DISABLE KEYS */;
INSERT INTO `seg_usuario` VALUES (1,2,'franco','6dd1411a66159040b7fff30d0097dbe4','ACT',NULL,'2018-05-30 20:41:02',NULL,NULL),(2,3,'rodrigo','2e247e2eb505c42b362e80ed4d05b078','ACT',NULL,'2018-05-30 20:41:02',NULL,NULL),(3,4,'josias','854a3864c2bef0b3948892a2c7b93ddd','ACT',NULL,'2018-05-30 20:41:02',NULL,NULL),(4,1,'bvez','bruno','ACT',NULL,'2018-05-30 15:53:02',NULL,NULL),(5,1,'usrAlm1','123','ACT',NULL,'2018-05-30 17:36:02',NULL,NULL);
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
  `estado` varchar(3) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_3` (`id_rol`),
  KEY `REL_4` (`id_usuario`),
  CONSTRAINT `REL_3` FOREIGN KEY (`id_rol`) REFERENCES `seg_rol` (`id`),
  CONSTRAINT `REL_4` FOREIGN KEY (`id_usuario`) REFERENCES `seg_usuario` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_usuario_rol`
--

LOCK TABLES `seg_usuario_rol` WRITE;
/*!40000 ALTER TABLE `seg_usuario_rol` DISABLE KEYS */;
INSERT INTO `seg_usuario_rol` VALUES (3,1,3,'ACT',NULL,'2018-05-30 20:41:42'),(4,2,3,'ACT',NULL,'2018-05-30 20:41:42'),(5,3,4,'ACT',NULL,'2018-05-30 20:41:42'),(6,4,2,'ACT',NULL,'2018-05-30 16:17:42'),(7,5,5,'ACT',NULL,'2018-05-30 17:36:42');
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
/*!50003 DROP PROCEDURE IF EXISTS `alm_listar_productos_registrables` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_listar_productos_registrables`(_idAlmacen int)
BEGIN
	SELECT * FROM prod_productos
    WHERE activo = 1 AND id_producto NOT IN (SELECT Producto_idProducto 
												FROM alm_producto_almacen 
												WHERE Almacen_idAlmacen = _idAlmacen);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_loguear_usuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_loguear_usuario`(
	IN _usuario varchar(200),
    IN _contrasena varchar(80),
    OUT _ingresoCorrecto bool,
    OUT _rol int,
    OUT _cantidadAlmacenes int
)
BEGIN
	DECLARE _idUsuario int DEFAULT -1;
    DECLARE _rolPrev int DEFAULT -1;
    DECLARE _ingresoPrev boolean DEFAULT FALSE;
	DECLARE _cantAlmacenesPrev int DEFAULT -1;
    
	#Se verifica su registro
    SELECT id INTO _idUsuario FROM seg_usuario WHERE usuario = _usuario AND clave = _contrasena AND estado = 'ACT';
    
    IF (_idUsuario>0) THEN
		BEGIN
			#se obtiene el rol del usuario
			SELECT id_rol into _rolPrev FROM seg_usuario_rol WHERE id_usuario = _idUsuario AND estado = 'ACT';
            #se verifica que el rol corresponda a alguien de almacen
            #Jefe de Almacen
            IF (_rolPrev=2) THEN
				BEGIN
					set _ingresoPrev := TRUE;
                    SELECT COUNT(*) INTO _cantAlmacenesPrev FROM alm_usuario_almacen WHERE idUsuario = _idUsuario AND habilitado = 1;
				END;
			#Usuario de Almacen
            ELSEIF (_rolPrev=5) THEN
				BEGIN
					set _ingresoPrev := TRUE;
                    SELECT COUNT(*) INTO _cantAlmacenesPrev FROM alm_usuario_almacen WHERE idUsuario = _idUsuario AND habilitado = 1;
                    #se muestra todos los almacenes en los que se encuentra registrado el usuario
					SELECT alm_almacen.idAlmacen,alm_almacen.direccion,alm_almacen.telefono
						FROM alm_usuario_almacen INNER JOIN alm_almacen ON alm_usuario_almacen.idAlmacen = alm_almacen.idAlmacen AND alm_almacen.habilitado=1;
                END;
			END IF;
		END;
	END IF;
    
    SET _ingresoCorrecto = _ingresoPrev;
    SET _rol = _rolPrev;
    SET _cantidadAlmacenes = _cantAlmacenesPrev;

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
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_manivela` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_manivela`(
					IN _id_manivela INT
)
BEGIN
	declare _fecha timestamp default current_timestamp;
    
	update prod_productos set fecha_modificacion=_fecha,activo=0 where id_producto=_id_manivela;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_perilla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_perilla`(
					IN _id_perilla INT
)
BEGIN
	declare _fecha timestamp default current_timestamp;
    
	update prod_productos set fecha_modificacion=_fecha,activo=0 where id_producto=_id_perilla;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_polea` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_polea`(
					IN _id_polea INT
)
BEGIN
	declare _fecha timestamp default current_timestamp;
    
	update prod_productos set fecha_modificacion=_fecha,activo=0 where id_producto=_id_polea;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_manivela` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_manivela`(
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DOUBLE,
                    IN _id_unidad_monetaria INT,
                    IN _diametro VARCHAR(100),
                    IN _id_unidad_producto INT,
                    OUT _id_manivela INT
)
BEGIN
	declare _id_tipo_producto int;
    declare _fecha timestamp default current_timestamp;
    
    select id_tipo_producto into _id_tipo_producto from prod_tipos_productos where nombre="POLEA";
    
	if _descripcion = "" then
		insert into prod_productos (id_tipo_producto,nombre,precio_venta,id_unidad_monetaria,fecha_creacion,fecha_modificacion,activo)
        values (_id_tipo_producto,_nombre,_precio_venta,_id_unidad_monetaria,_fecha,_fecha,1);
	else
		insert into prod_productos (id_tipo_producto,nombre,descripcion,precio_venta,id_unidad_monetaria,fecha_creacion,fecha_modificacion,activo)
        values (_id_tipo_producto,_nombre,_descripcion,_precio_venta,_id_unidad_monetaria,_fecha,_fecha,1);
    end if;
    
    set _id_manivela=last_insert_id();
    
    insert into prod_manivelas (id_manivela,diametro,id_unidad_manivela)
    values (_id_manivela,_diametro,_id_unidad_producto);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_perilla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_perilla`(
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DOUBLE,
                    IN _id_unidad_monetaria INT,
                    IN _diametro VARCHAR(100),
                    IN _longitud VARCHAR(100),
                    IN _id_unidad_producto INT,
                    OUT _id_perilla INT
)
BEGIN
	declare _id_tipo_producto int;
    declare _fecha timestamp default current_timestamp;
    
    select id_tipo_producto into _id_tipo_producto from prod_tipos_productos where nombre="POLEA";
    
	if _descripcion = "" then
		insert into prod_productos (id_tipo_producto,nombre,precio_venta,id_unidad_monetaria,fecha_creacion,fecha_modificacion,activo)
        values (_id_tipo_producto,_nombre,_precio_venta,_id_unidad_monetaria,_fecha,_fecha,1);
	else
		insert into prod_productos (id_tipo_producto,nombre,descripcion,precio_venta,id_unidad_monetaria,fecha_creacion,fecha_modificacion,activo)
        values (_id_tipo_producto,_nombre,_descripcion,_precio_venta,_id_unidad_monetaria,_fecha,_fecha,1);
    end if;
    
    set _id_perilla=last_insert_id();
    
    insert into prod_perillas (id_perilla,diametro,longitud,id_unidad_perilla)
    values (_id_perilla,_diametro,_longitud,_id_unidad_producto);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_polea` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_polea`(
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DOUBLE,
                    IN _id_unidad_monetaria INT,
                    IN _id_tipo_canal INT,
                    IN _diametro VARCHAR(100),
                    IN _id_unidad_producto INT,
                    IN _cantidad_canales INT,
                    OUT _id_polea INT
)
BEGIN
	declare _id_tipo_producto int;
    declare _fecha timestamp default current_timestamp;
    
    select id_tipo_producto into _id_tipo_producto from prod_tipos_productos where nombre="POLEA";
    
	if _descripcion = "" then
		insert into prod_productos (id_tipo_producto,nombre,precio_venta,id_unidad_monetaria,fecha_creacion,fecha_modificacion,activo)
        values (_id_tipo_producto,_nombre,_precio_venta,_id_unidad_monetaria,_fecha,_fecha,1);
	else
		insert into prod_productos (id_tipo_producto,nombre,descripcion,precio_venta,id_unidad_monetaria,fecha_creacion,fecha_modificacion,activo)
        values (_id_tipo_producto,_nombre,_descripcion,_precio_venta,_id_unidad_monetaria,_fecha,_fecha,1);
    end if;
    
    set _id_polea=last_insert_id();
    
    insert into prod_poleas (id_polea,id_tipo_canal,diametro,id_unidad_polea,cantidad_canales)
    values (_id_polea,_tipo_canal,_diametro,_id_unidad_producto,_cantidad_canales);
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
/*!50003 DROP PROCEDURE IF EXISTS `modificar_manivela` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modificar_manivela`(
					IN _id_manivela INT,
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DOUBLE,
                    IN _id_unidad_monetaria INT,
                    IN _diametro VARCHAR(100),
                    IN _id_unidad_producto INT
)
BEGIN
    declare _fecha timestamp default current_timestamp;
    
	if _descripcion = "" then
		update prod_productos set nombre=_nombre,descripcion=NULL,precio_venta=_precio_venta,
        id_unidad_monetaria=_id_unidad_monetaria,fecha_modificacion=_fecha where id_producto=_id_manivela;
	else
		update prod_productos set nombre=_nombre,descripcion=_descripcion,precio_venta=_precio_venta,
        id_unidad_monetaria=_id_unidad_monetaria,fecha_modificacion=_fecha where id_producto=_id_manivela;
    end if;
    
    update prod_manivelas set diametro=_diametro,
    id_unidad_manivela=_id_unidad_producto where id_manivela=_id_manivela;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `modificar_perilla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modificar_perilla`(
					IN _id_perilla INT,
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DOUBLE,
                    IN _id_unidad_monetaria INT,
                    IN _diametro VARCHAR(100),
                    IN _longitud VARCHAR(100),
                    IN _id_unidad_producto INT
)
BEGIN
    declare _fecha timestamp default current_timestamp;
    
	if _descripcion = "" then
		update prod_productos set nombre=_nombre,descripcion=NULL,precio_venta=_precio_venta,
        id_unidad_monetaria=_id_unidad_monetaria,fecha_modificacion=_fecha where id_producto=_id_perilla;
	else
		update prod_productos set nombre=_nombre,descripcion=_descripcion,precio_venta=_precio_venta,
        id_unidad_monetaria=_id_unidad_monetaria,fecha_modificacion=_fecha where id_producto=_id_perilla;
    end if;
    
    update prod_perillas set diametro=_diametro,longitud=_longitud,
    id_unidad_perilla=_id_unidad_producto where id_perilla=_id_perilla;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `modificar_polea` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modificar_polea`(
					IN _id_polea INT,
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DOUBLE,
                    IN _id_unidad_monetaria INT,
                    IN _id_tipo_canal INT,
                    IN _diametro VARCHAR(100),
                    IN _id_unidad_producto INT,
                    IN _cantidad_canales INT
)
BEGIN
    declare _fecha timestamp default current_timestamp;
    
	if _descripcion = "" then
		update prod_productos set nombre=_nombre,descripcion=NULL,precio_venta=_precio_venta,
        id_unidad_monetaria=_id_unidad_monetaria,fecha_modificacion=_fecha where id_producto=_id_polea;
	else
		update prod_productos set nombre=_nombre,descripcion=_descripcion,precio_venta=_precio_venta,
        id_unidad_monetaria=_id_unidad_monetaria,fecha_modificacion=_fecha where id_producto=_id_polea;
    end if;
    
    update prod_poleas set id_tipo_canal=_id_tipo_canal,diametro=_diametro,
    id_unidad_polea=_id_unidad_producto,cantidad_canales=_cantidad_canales where id_polea=_id_polea;
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

-- Dump completed on 2018-05-30 23:34:51
