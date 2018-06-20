-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: quilla.lab.inf.pucp.edu.pe    Database: inf282g2b
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_almacen`
--

LOCK TABLES `alm_almacen` WRITE;
/*!40000 ALTER TABLE `alm_almacen` DISABLE KEYS */;
INSERT INTO `alm_almacen` VALUES (1,'Direccion del almacen 1','111-1111',1,1),(2,'Direccion del almacen 2','222-2222',1,1),(3,'Direccion del almacen 3','333-3333',1,1),(4,'Direccion del almacen 4','444-4444',1,1),(5,'Direccion del almacen 5','555-5555',1,1),(6,'Calle del Nuevo Almacen 666','654-123',1,1),(7,'Calle Almacen Nuevo 123','123123',1,1),(8,'av universitrar 1801','4513164136',0,1);
/*!40000 ALTER TABLE `alm_almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_detalle_pedido_a_produccion`
--

DROP TABLE IF EXISTS `alm_detalle_pedido_a_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_detalle_pedido_a_produccion` (
  `idDetallePedidoProduccion` int(11) NOT NULL AUTO_INCREMENT,
  `idPedidoProduccion` int(11) NOT NULL,
  `idProductoPedido` int(11) NOT NULL,
  `cantidadPedida` int(11) NOT NULL,
  `activo` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT '',
  PRIMARY KEY (`idDetallePedidoProduccion`),
  KEY `FK_ID_PRODUCTO_idx` (`idProductoPedido`),
  KEY `FK_ID_PEDIDO_idx` (`idPedidoProduccion`),
  CONSTRAINT `FK_ID_PEDIDO_DETALLE` FOREIGN KEY (`idPedidoProduccion`) REFERENCES `alm_pedido_a_produccion` (`ID_PEDIDO`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ID_PRODUCTO_DETALLE` FOREIGN KEY (`idProductoPedido`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_detalle_pedido_a_produccion`
--

LOCK TABLES `alm_detalle_pedido_a_produccion` WRITE;
/*!40000 ALTER TABLE `alm_detalle_pedido_a_produccion` DISABLE KEYS */;
INSERT INTO `alm_detalle_pedido_a_produccion` VALUES (1,7,3,30,0,''),(2,8,1,10,2,''),(3,8,3,10,0,''),(4,10,3,20,0,'Para ahora xd'),(5,11,1,2,2,'Pedido 1 de prueba'),(6,11,3,3,0,'Pedido 2 de prueba'),(7,12,3,30,0,'Pedido de prueba'),(8,13,3,40,0,''),(9,14,6,60,0,'prueba de jorge'),(10,15,8,2000,0,'jorge2'),(11,16,8,2000,0,'jorge2'),(12,17,8,2000,0,'jorge2'),(13,18,12,10,0,''),(14,19,12,10,0,'PAUCAR'),(15,19,15,1,0,'PAUCAR'),(16,19,11,89,0,''),(17,20,1,2,0,'Prueba Bruno'),(18,21,2,0,0,''),(19,21,3,0,0,''),(20,21,12,0,0,'');
/*!40000 ALTER TABLE `alm_detalle_pedido_a_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_ingresos_y_salidas`
--

DROP TABLE IF EXISTS `alm_ingresos_y_salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_ingresos_y_salidas` (
  `id_movimiento` int(11) NOT NULL AUTO_INCREMENT,
  `id_area_origen` int(11) NOT NULL,
  `id_sede_origen` int(11) NOT NULL,
  `id_area_destino` int(11) NOT NULL,
  `id_sede_destino` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT '',
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `habilitado` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `fk_area_origen_idx` (`id_area_origen`),
  KEY `fk_area_destino_idx` (`id_area_destino`),
  CONSTRAINT `fk_area_destino` FOREIGN KEY (`id_area_destino`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_area_origen` FOREIGN KEY (`id_area_origen`) REFERENCES `gen_areas` (`id_area`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_ingresos_y_salidas`
--

LOCK TABLES `alm_ingresos_y_salidas` WRITE;
/*!40000 ALTER TABLE `alm_ingresos_y_salidas` DISABLE KEYS */;
INSERT INTO `alm_ingresos_y_salidas` VALUES (1,1,0,1,1,'Prueba 2 General','2018-06-14','2018-06-14',1),(2,1,2,1,1,'','2018-06-14','2018-06-14',1),(3,1,2,1,1,'Prueba 3 General','2018-06-14','2018-06-14',1),(4,1,1,1,2,'Prueba 4 General','2018-06-14','2018-06-14',1),(5,1,6,1,1,'','2018-06-14','2018-06-14',1),(6,1,6,1,1,'','2018-06-14','2018-06-14',1),(7,1,1,1,1,'hui','2018-06-14','2018-06-14',1),(8,1,1,1,3,'hjk','2018-06-14','2018-06-14',1),(9,2,-1,1,2,'alf','2018-06-19','2018-06-19',1),(10,1,1,1,2,'asddasd','2018-06-19','2018-06-19',1),(11,1,1,1,2,'','2018-06-19','2018-06-19',1),(12,1,1,1,2,'','2018-06-19','2018-06-19',1),(13,1,1,1,2,'','2018-06-19','2018-06-19',1),(14,1,1,1,2,'','2018-06-19','2018-06-19',1),(15,1,1,1,2,'','2018-06-19','2018-06-19',1),(16,1,1,1,1,'Prueba Bruno','2018-06-19','2018-06-19',1),(17,1,1,1,1,'Prueba Bruno','2018-06-19','2018-06-19',1);
/*!40000 ALTER TABLE `alm_ingresos_y_salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_linea_ingreso`
--

DROP TABLE IF EXISTS `alm_linea_ingreso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_linea_ingreso` (
  `id_alm_linea_ingreso` int(11) NOT NULL AUTO_INCREMENT,
  `id_movimiento` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT '',
  PRIMARY KEY (`id_alm_linea_ingreso`),
  KEY `fk_idProducto_idx` (`id_producto`),
  KEY `fk_idMovimiento_idx` (`id_movimiento`),
  CONSTRAINT `fk_id_movimiento` FOREIGN KEY (`id_movimiento`) REFERENCES `alm_ingresos_y_salidas` (`id_movimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_id_producto` FOREIGN KEY (`id_producto`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_linea_ingreso`
--

LOCK TABLES `alm_linea_ingreso` WRITE;
/*!40000 ALTER TABLE `alm_linea_ingreso` DISABLE KEYS */;
INSERT INTO `alm_linea_ingreso` VALUES (1,2,1,10,''),(2,3,3,30,'Linea Prueba3'),(3,3,1,5,'Linea Prueba3'),(4,7,1,12,''),(5,9,2,1,'safdafa'),(6,9,12,1,'sfa'),(7,10,12,5,''),(8,11,12,10,''),(9,12,12,20,''),(10,13,8,25,''),(11,14,8,500,''),(12,15,15,4,''),(13,16,1,50,'Prueba Bruno');
/*!40000 ALTER TABLE `alm_linea_ingreso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_linea_salida`
--

DROP TABLE IF EXISTS `alm_linea_salida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_linea_salida` (
  `id_linea_salida` int(11) NOT NULL AUTO_INCREMENT,
  `id_movimiento` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT '',
  PRIMARY KEY (`id_linea_salida`),
  KEY `id_producto_salidas_idx` (`id_producto`),
  KEY `movimiento_salida` (`id_movimiento`),
  CONSTRAINT `id_producto_salida` FOREIGN KEY (`id_producto`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `movimiento_salida` FOREIGN KEY (`id_movimiento`) REFERENCES `alm_ingresos_y_salidas` (`id_movimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_linea_salida`
--

LOCK TABLES `alm_linea_salida` WRITE;
/*!40000 ALTER TABLE `alm_linea_salida` DISABLE KEYS */;
INSERT INTO `alm_linea_salida` VALUES (1,4,1,15,'Salida Prueba 4'),(2,4,3,30,'Salida Prueba 4'),(3,5,3,30,''),(4,6,2,30,''),(5,8,3,30,'oih'),(6,17,1,50,'Prueba Bruno');
/*!40000 ALTER TABLE `alm_linea_salida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alm_pedido_a_produccion`
--

DROP TABLE IF EXISTS `alm_pedido_a_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alm_pedido_a_produccion` (
  `ID_PEDIDO` int(11) NOT NULL AUTO_INCREMENT,
  `ID_ALMACEN` int(11) NOT NULL,
  `ACTIVO` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_PEDIDO`),
  KEY `ID_ALMACEN_idx` (`ID_ALMACEN`),
  CONSTRAINT `ID_ALMACEN` FOREIGN KEY (`ID_ALMACEN`) REFERENCES `alm_almacen` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alm_pedido_a_produccion`
--

LOCK TABLES `alm_pedido_a_produccion` WRITE;
/*!40000 ALTER TABLE `alm_pedido_a_produccion` DISABLE KEYS */;
INSERT INTO `alm_pedido_a_produccion` VALUES (1,1,1),(2,1,1),(3,1,1),(4,1,1),(5,3,1),(6,3,1),(7,3,1),(8,1,1),(10,3,1),(11,1,1),(12,6,1),(13,1,1),(14,2,1),(15,2,1),(16,2,1),(17,2,1),(18,2,1),(19,2,1),(20,1,1),(21,2,1);
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
INSERT INTO `alm_producto_almacen` VALUES (1,1,27),(2,2,21),(2,3,25),(3,3,30),(4,8,40),(1,3,0),(6,1,60),(2,6,60),(6,2,30),(6,3,30),(6,8,60),(6,10,60),(7,13,20),(7,8,6),(7,15,20),(2,15,8),(2,11,12),(2,12,40),(2,8,1525),(8,8,0),(8,10,99999);
/*!40000 ALTER TABLE `alm_producto_almacen` ENABLE KEYS */;
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
INSERT INTO `alm_usuario_almacen` VALUES (1,5,1),(1,6,1),(1,13,1),(1,16,1),(2,5,1),(2,7,1),(2,16,1),(3,8,1),(3,16,1),(4,9,1),(5,10,1),(6,15,1);
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
INSERT INTO `gen_areas` VALUES (1,'Almacen','2018-05-30 00:00:00','2018-05-30 00:00:00',1),(2,'Ventas','2018-05-30 00:00:00','2018-05-30 00:00:00',1),(3,'Produccion','2018-05-30 00:00:00','2018-05-30 00:00:00',1);
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
  `id_representante` int(15) DEFAULT NULL,
  `razon_social` varchar(100) DEFAULT NULL,
  `giro_negocio` varchar(100) DEFAULT NULL,
  `ruc` varchar(11) DEFAULT NULL,
  `telefono` varchar(9) DEFAULT NULL,
  `celular` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `estado` varchar(3) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_9` (`id_representante`),
  CONSTRAINT `REL_9` FOREIGN KEY (`id_representante`) REFERENCES `gen_persona` (`id`)
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
  `id_user_modifica` int(15) DEFAULT NULL,
  `fecha_modifica` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQUE_Persona_1` (`numero_doc_identidad`,`email`),
  KEY `REL_1` (`id_tipo_doc_identidad`),
  CONSTRAINT `REL_1` FOREIGN KEY (`id_tipo_doc_identidad`) REFERENCES `gen_tipo_doc_identidad` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_persona`
--

LOCK TABLES `gen_persona` WRITE;
/*!40000 ALTER TABLE `gen_persona` DISABLE KEYS */;
INSERT INTO `gen_persona` VALUES (1,'Bruno','Espezúa','',NULL,NULL,'M','bruno.espezua@pucp.pe',NULL,NULL,1,'77591264',NULL,NULL,NULL,NULL,NULL,NULL),(2,'Franco','Pariasca',NULL,NULL,NULL,'M','correo de franco',NULL,NULL,1,'DNI de Franco',NULL,NULL,NULL,NULL,NULL,NULL),(3,'Rodrigo','Suarez',NULL,NULL,NULL,'M','correo de rodrigo',NULL,NULL,1,'DNI de Rodrigo',NULL,NULL,NULL,NULL,NULL,NULL),(4,'Josias','Carhuas','Ospina',NULL,NULL,'M','jcarhuasp@gmail.com',NULL,NULL,1,'47059190',NULL,NULL,NULL,NULL,NULL,NULL),(5,'Harleen','Viguria',NULL,NULL,NULL,'M','correo de Harleen',NULL,NULL,1,'DNI de Harleen',NULL,NULL,NULL,NULL,NULL,NULL),(6,'Paulo','Tuya',NULL,NULL,NULL,'M','correo de Paulo',NULL,NULL,1,'DNI de Paulo',NULL,NULL,NULL,NULL,NULL,NULL),(17,'Francisco','Rios','Lopez',NULL,NULL,'M','francisco@agmail.com','958473847',NULL,1,'47048389','Jiron Alameda 23 Santido de Surco','CRE',3,'2018-06-14 04:58:00',NULL,NULL),(18,'German','Martinez','Ulloa',NULL,NULL,'M','german@martinez','945745754',NULL,1,'34549591','Jiron Los Urbines 123 - Santa Teresa','CRE',3,'2018-06-14 05:45:01',NULL,NULL),(19,'Silvia','Olvera','Aguilera',NULL,NULL,'F','silvia@olvera.com','943754734',NULL,1,'45095867','Jiron Los Condores 123 - Santa Anita','CRE',3,'2018-06-14 07:03:57',NULL,NULL),(20,'Juan','Perales','Morales',NULL,NULL,'M','joss@com','958745875',NULL,1,'47251478','Los geranios 547','CRE',3,'2018-06-14 15:17:10',NULL,NULL),(21,'Erasmo','Perez','Lopez',NULL,NULL,'M','asas@asas','958745236',NULL,1,'25147896','Las grullas 159 SAnta anuita','CRE',3,'2018-06-14 17:02:54',NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gen_tipo_doc_identidad`
--

LOCK TABLES `gen_tipo_doc_identidad` WRITE;
/*!40000 ALTER TABLE `gen_tipo_doc_identidad` DISABLE KEYS */;
INSERT INTO `gen_tipo_doc_identidad` VALUES (1,'DNI','Documento Nacional de Identidad'),(2,'CE','Carnet de Extranjería'),(3,'PAS','Pasaporte');
/*!40000 ALTER TABLE `gen_tipo_doc_identidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_detalles_lista_produccion`
--

DROP TABLE IF EXISTS `prod_detalles_lista_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_detalles_lista_produccion` (
  `ID_DETALLE_LISTA_PRODUCCION` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PRODUCTO` int(11) NOT NULL,
  `CANTIDAD_SOLICITADA` int(11) NOT NULL,
  `CANTIDAD_FABRICADA` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_DETALLE_LISTA_PRODUCCION`,`ID_PRODUCTO`),
  KEY `ID_PRODUCTO _idx` (`ID_PRODUCTO`),
  CONSTRAINT `ID_PRODUC` FOREIGN KEY (`ID_PRODUCTO`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_detalles_lista_produccion`
--

LOCK TABLES `prod_detalles_lista_produccion` WRITE;
/*!40000 ALTER TABLE `prod_detalles_lista_produccion` DISABLE KEYS */;
INSERT INTO `prod_detalles_lista_produccion` VALUES (1,3,103,NULL),(2,1,12,NULL),(2,3,103,NULL),(3,1,12,NULL),(3,3,103,NULL),(4,3,60,NULL),(5,1,12,NULL),(5,3,103,NULL),(6,1,12,NULL),(6,3,30,NULL),(6,8,4000,NULL),(7,1,12,NULL),(7,3,30,NULL),(7,8,6000,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_estados`
--

LOCK TABLES `prod_estados` WRITE;
/*!40000 ALTER TABLE `prod_estados` DISABLE KEYS */;
INSERT INTO `prod_estados` VALUES (1,'EstadoFranco','HOLIWIS',1),(2,'EstadoRodrigo','HOLIWIS x2',1),(3,'EstadoJosias','HOLIWIS x3',1),(4,'PENDIENTE',NULL,1),(5,'REALIZADO',NULL,1);
/*!40000 ALTER TABLE `prod_estados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_lista_pedidos`
--

DROP TABLE IF EXISTS `prod_lista_pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_lista_pedidos` (
  `ID_LISTA_PEDIDOS` int(11) NOT NULL AUTO_INCREMENT,
  `ID_PEDIDO` int(11) NOT NULL,
  PRIMARY KEY (`ID_LISTA_PEDIDOS`,`ID_PEDIDO`),
  CONSTRAINT `ID_LISTA_PEDIDOS` FOREIGN KEY (`ID_LISTA_PEDIDOS`) REFERENCES `alm_detalle_pedido_a_produccion` (`idDetallePedidoProduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_lista_pedidos`
--

LOCK TABLES `prod_lista_pedidos` WRITE;
/*!40000 ALTER TABLE `prod_lista_pedidos` DISABLE KEYS */;
INSERT INTO `prod_lista_pedidos` VALUES (1,8),(1,10),(1,11),(1,12),(1,13),(2,7),(2,8),(2,10),(2,11),(2,13),(3,7),(3,8),(3,10),(3,11),(3,13),(4,7),(4,8),(4,10),(5,7),(5,8),(5,10),(5,11),(5,13),(6,7),(6,8),(6,11),(6,15),(6,17),(7,7),(7,8),(7,11),(7,15),(7,16),(7,17);
/*!40000 ALTER TABLE `prod_lista_pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_listas_de_produccion`
--

DROP TABLE IF EXISTS `prod_listas_de_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_listas_de_produccion` (
  `ID_LISTA_DE_PRODUCCION` int(11) NOT NULL AUTO_INCREMENT,
  `ID_LOCAL` int(11) NOT NULL,
  `ID_DETALLE_LISTA_PRODUCCION` int(11) NOT NULL,
  `ID_LISTA_PEDIDOS` int(11) NOT NULL,
  `FECHA_CREACION` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `FECHA_MODIFICACION` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `ID_ESTADO` int(11) NOT NULL,
  `ACTIVO` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID_LISTA_DE_PRODUCCION`),
  KEY `ID_DETALLE_LISTA_PRODUCCION_idx` (`ID_DETALLE_LISTA_PRODUCCION`),
  KEY `ID_LOCAL_PRODUCCION_idx` (`ID_LOCAL`),
  KEY `ID_LISTA_PEDIDOS_idx` (`ID_LISTA_PEDIDOS`),
  CONSTRAINT `ID_DETALLE_LISTA_PRODUCCION` FOREIGN KEY (`ID_DETALLE_LISTA_PRODUCCION`) REFERENCES `prod_detalles_lista_produccion` (`ID_DETALLE_LISTA_PRODUCCION`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ID_LOCAL_PRODUCCION` FOREIGN KEY (`ID_LOCAL`) REFERENCES `prod_locales` (`id_local`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_listas_de_produccion`
--

LOCK TABLES `prod_listas_de_produccion` WRITE;
/*!40000 ALTER TABLE `prod_listas_de_produccion` DISABLE KEYS */;
INSERT INTO `prod_listas_de_produccion` VALUES (1,1,1,1,'2018-06-19 06:02:15','2018-06-19 06:02:15',4,1),(2,1,2,2,'2018-06-19 07:23:44','2018-06-19 07:23:44',4,1),(3,1,3,3,'2018-06-19 07:34:00','2018-06-19 07:34:00',4,1),(4,1,4,4,'2018-06-19 07:34:12','2018-06-19 07:34:12',4,1),(5,1,5,5,'2018-06-19 07:34:29','2018-06-19 07:34:29',4,1),(6,1,6,6,'2018-06-19 21:35:15','2018-06-19 21:35:15',4,1),(7,1,7,7,'2018-06-19 21:35:48','2018-06-19 21:35:48',4,1);
/*!40000 ALTER TABLE `prod_listas_de_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prod_locales`
--

DROP TABLE IF EXISTS `prod_locales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_locales` (
  `id_local` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_local` varchar(100) NOT NULL,
  `activo` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_local`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_locales`
--

LOCK TABLES `prod_locales` WRITE;
/*!40000 ALTER TABLE `prod_locales` DISABLE KEYS */;
INSERT INTO `prod_locales` VALUES (1,'Local de Produccion 1',1);
/*!40000 ALTER TABLE `prod_locales` ENABLE KEYS */;
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
INSERT INTO `prod_manivelas` VALUES (7,'34.24',1),(8,'8/5',1),(9,'13/5',1),(11,'5/13',1),(12,'7/8',1),(14,'15',1),(15,'5/7',1),(16,'7/8',1);
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
  CONSTRAINT `id_perilla` FOREIGN KEY (`id_perilla`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidad_perilla` FOREIGN KEY (`id_unidad_perilla`) REFERENCES `prod_unidades_productos` (`id_unidad_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
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
  CONSTRAINT `id_polea` FOREIGN KEY (`id_polea`) REFERENCES `prod_productos` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_tipo_canal_polea` FOREIGN KEY (`id_tipo_canal`) REFERENCES `prod_tipos_canales` (`id_tipo_canal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `unidad_polea` FOREIGN KEY (`id_unidad_polea`) REFERENCES `prod_unidades_productos` (`id_unidad_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_poleas`
--

LOCK TABLES `prod_poleas` WRITE;
/*!40000 ALTER TABLE `prod_poleas` DISABLE KEYS */;
INSERT INTO `prod_poleas` VALUES (1,1,'3/80',1,2),(2,1,'5/8',1,2),(13,1,'9/7',1,2);
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
  `descripcion` varchar(100) DEFAULT '',
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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_productos`
--

LOCK TABLES `prod_productos` WRITE;
/*!40000 ALTER TABLE `prod_productos` DISABLE KEYS */;
INSERT INTO `prod_productos` VALUES (1,1,'Polea de 3/80',' ',87.65,4,'2018-05-31 00:11:59','2018-05-31 00:56:25',0),(2,1,'Polea 5/8','Es una polea de 5/8',35.12,1,'2018-05-31 00:12:54','2018-05-31 07:48:37',1),(3,1,'Perilla 3/8','Es una perilla de 3/8',45.87,1,'2018-05-31 05:22:21','2018-05-31 05:42:57',1),(4,1,'Perilla 5/8',' ',54.63,1,'2018-05-31 05:24:14','2018-05-31 05:46:59',0),(5,1,'Producto 5','5/2',34.24,3,'2018-05-31 06:45:16','2018-05-31 07:01:38',0),(6,1,'Producto 6','5/2',34.24,3,'2018-05-31 06:45:40','2018-05-31 07:01:30',0),(7,1,'Producto 7','5/2',34.24,3,'2018-05-31 06:45:54','2018-05-31 07:01:13',0),(8,1,'Manivela 8/5','Es una manivela de 8/5',54.80,2,'2018-05-31 06:47:52','2018-05-31 06:57:02',1),(9,1,'Manivela 13/5',' ',87.50,4,'2018-05-31 06:48:55','2018-05-31 07:01:46',0),(10,1,'Polea 7/13','',1800.35,3,'2018-05-31 21:59:47','2018-05-31 21:59:47',1),(11,1,'Manivela 5/13','',38.50,1,'2018-05-31 22:00:21','2018-05-31 22:00:21',1),(12,1,'Manivela 7/8','',23.34,1,'2018-05-31 22:04:00','2018-05-31 22:04:00',1),(13,1,'Polea 9/7','',98.70,2,'2018-05-31 22:07:30','2018-05-31 22:07:30',1),(14,1,'AWDADAD','',35.54,1,'2018-06-12 06:14:50','2018-06-12 06:22:04',0),(15,1,'Manivela Nueva','manivla no elegante',153.57,2,'2018-06-14 21:44:45','2018-06-14 21:44:45',1),(16,1,'Manivela asd','',567.54,4,'2018-06-14 22:09:48','2018-06-14 22:09:48',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_unidades_productos`
--

LOCK TABLES `prod_unidades_productos` WRITE;
/*!40000 ALTER TABLE `prod_unidades_productos` DISABLE KEYS */;
INSERT INTO `prod_unidades_productos` VALUES (1,'pulgada','',1),(2,'m²','metro cuadrado',1),(3,'cm²','centimetro cuadrado',1),(4,'Kg','Kilogramos',1);
/*!40000 ALTER TABLE `prod_unidades_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prov_insumo`
--

DROP TABLE IF EXISTS `prov_insumo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prov_insumo` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(25) DEFAULT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `id_unidad` varchar(45) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prov_insumo`
--

LOCK TABLES `prov_insumo` WRITE;
/*!40000 ALTER TABLE `prov_insumo` DISABLE KEYS */;
INSERT INTO `prov_insumo` VALUES (1,'ALUBL','Aluminio blando',NULL,'4',3,'2018-06-13 15:59:58'),(2,'ALUDR','Aluminio duro',NULL,'4',3,'2018-06-13 15:59:58'),(3,'ALUST','Aluminio estándar',NULL,'4',3,'2018-06-13 15:59:58');
/*!40000 ALTER TABLE `prov_insumo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prov_insumo_proveedor`
--

DROP TABLE IF EXISTS `prov_insumo_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prov_insumo_proveedor` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `id_proveedor` int(15) NOT NULL,
  `id_insumo` int(15) NOT NULL,
  `cantidad` int(15) DEFAULT NULL,
  `monto` decimal(15,5) DEFAULT NULL,
  `estado` varchar(3) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_modifica` int(15) DEFAULT NULL,
  `fecha_modifica` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_11` (`id_proveedor`),
  KEY `REL_10` (`id_insumo`),
  CONSTRAINT `REL_10` FOREIGN KEY (`id_insumo`) REFERENCES `prov_insumo` (`id`),
  CONSTRAINT `REL_11` FOREIGN KEY (`id_proveedor`) REFERENCES `prov_proveedor` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prov_insumo_proveedor`
--

LOCK TABLES `prov_insumo_proveedor` WRITE;
/*!40000 ALTER TABLE `prov_insumo_proveedor` DISABLE KEYS */;
INSERT INTO `prov_insumo_proveedor` VALUES (3,11,1,NULL,NULL,'ACT',3,'2018-06-14 04:58:00',NULL,NULL),(4,11,2,NULL,NULL,'ACT',3,'2018-06-14 04:58:00',NULL,NULL),(5,11,3,NULL,NULL,'ACT',3,'2018-06-14 04:58:00',NULL,NULL),(6,12,2,NULL,NULL,'ACT',3,'2018-06-14 05:45:01',NULL,NULL),(7,12,3,NULL,NULL,'ACT',3,'2018-06-14 05:45:01',NULL,NULL),(8,13,2,NULL,NULL,'ACT',3,'2018-06-14 07:03:57',NULL,NULL),(9,13,3,NULL,NULL,'ACT',3,'2018-06-14 07:03:57',NULL,NULL),(10,14,1,NULL,NULL,'ACT',3,'2018-06-14 15:17:10',NULL,NULL),(11,14,2,NULL,NULL,'ACT',3,'2018-06-14 15:17:10',NULL,NULL),(12,14,3,NULL,NULL,'ACT',3,'2018-06-14 15:17:10',NULL,NULL),(13,15,2,NULL,NULL,'ACT',3,'2018-06-14 17:02:54',NULL,NULL),(14,15,3,NULL,NULL,'ACT',3,'2018-06-14 17:02:55',NULL,NULL);
/*!40000 ALTER TABLE `prov_insumo_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prov_proveedor`
--

DROP TABLE IF EXISTS `prov_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prov_proveedor` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `id_natural` int(15) DEFAULT NULL,
  `id_compania` int(15) DEFAULT NULL,
  `tipo_prov` tinyint(15) DEFAULT NULL,
  `estado` varchar(3) DEFAULT NULL,
  `id_user_registro` int(15) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_modifica` int(11) DEFAULT NULL,
  `fecha_modifica` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_6` (`id_compania`),
  KEY `REL_8` (`id_natural`),
  CONSTRAINT `REL_6` FOREIGN KEY (`id_compania`) REFERENCES `gen_compania` (`id`),
  CONSTRAINT `REL_8` FOREIGN KEY (`id_natural`) REFERENCES `prov_proveedor_natural` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prov_proveedor`
--

LOCK TABLES `prov_proveedor` WRITE;
/*!40000 ALTER TABLE `prov_proveedor` DISABLE KEYS */;
INSERT INTO `prov_proveedor` VALUES (11,11,NULL,0,'ACT',3,'2018-06-14 04:58:00',NULL,NULL),(12,12,NULL,0,'ACT',3,'2018-06-14 05:45:01',NULL,NULL),(13,13,NULL,0,'ACT',3,'2018-06-14 07:03:57',NULL,NULL),(14,14,NULL,0,'ACT',3,'2018-06-14 15:17:10',NULL,NULL),(15,15,NULL,0,'ACT',3,'2018-06-14 17:02:54',NULL,NULL);
/*!40000 ALTER TABLE `prov_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prov_proveedor_natural`
--

DROP TABLE IF EXISTS `prov_proveedor_natural`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prov_proveedor_natural` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `id_persona` int(15) NOT NULL,
  `ruc` varchar(11) DEFAULT NULL,
  `estado` varchar(3) DEFAULT NULL,
  `id_user_registro` varchar(25) DEFAULT NULL,
  `fecha_registro` varchar(25) DEFAULT NULL,
  `id_user_modifica` int(11) DEFAULT NULL,
  `fecha_modifica` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `REL_5` (`id_persona`),
  CONSTRAINT `REL_5` FOREIGN KEY (`id_persona`) REFERENCES `gen_persona` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prov_proveedor_natural`
--

LOCK TABLES `prov_proveedor_natural` WRITE;
/*!40000 ALTER TABLE `prov_proveedor_natural` DISABLE KEYS */;
INSERT INTO `prov_proveedor_natural` VALUES (11,17,'10239943842','REG','3','2018-06-14 04:58:00',NULL,NULL),(12,18,'10234453234','REG','3','2018-06-14 05:45:01',NULL,NULL),(13,19,'10284432124','REG','3','2018-06-14 07:03:57',NULL,NULL),(14,20,'10254474527','REG','3','2018-06-14 15:17:10',NULL,NULL),(15,21,'12326545896','REG','3','2018-06-14 17:02:54',NULL,NULL);
/*!40000 ALTER TABLE `prov_proveedor_natural` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_rol`
--

LOCK TABLES `seg_rol` WRITE;
/*!40000 ALTER TABLE `seg_rol` DISABLE KEYS */;
INSERT INTO `seg_rol` VALUES (1,'Jefe de Ventas','JVEN','2018-05-30 20:35:42'),(2,'Jefe de Almacenes','JALM','2018-05-30 20:35:42'),(3,'Jefe de Producción','JPROD','2018-05-30 20:35:42'),(4,'Jefe de Compras Y Proveedores','JCPROV','2018-05-30 20:35:42'),(5,'Usuario de Almacen','UALM','2018-05-30 15:51:42'),(6,'Ejecutivo de Ventas','EVEN','2018-06-10 16:46:42'),(7,'Administrador de Seguridad','ADMINSEG','2018-06-17 15:46:20');
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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_usuario`
--

LOCK TABLES `seg_usuario` WRITE;
/*!40000 ALTER TABLE `seg_usuario` DISABLE KEYS */;
INSERT INTO `seg_usuario` VALUES (1,2,'franco','6dd1411a66159040b7fff30d0097dbe4','ACT',NULL,'2018-05-30 20:41:02',NULL,NULL),(2,3,'rodrigo','2e247e2eb505c42b362e80ed4d05b078','ACT',NULL,'2018-05-30 20:41:02',NULL,NULL),(3,4,'josias','854a3864c2bef0b3948892a2c7b93ddd','ACT',NULL,'2018-05-30 20:41:02',NULL,NULL),(4,1,'bvez','bruno','ACT',NULL,'2018-05-30 15:53:02',NULL,NULL),(5,1,'usrAlm1','123','ACT',NULL,'2018-05-30 17:36:02',NULL,NULL),(6,1,'user1','123','ACT',NULL,'2018-05-31 04:50:02',NULL,NULL),(7,1,'user2','123','ACT',NULL,'2018-05-31 04:50:02',NULL,NULL),(8,1,'user3','123','ACT',NULL,'2018-05-31 04:50:02',NULL,NULL),(9,1,'user4','123','ACT',NULL,'2018-05-31 04:50:02',NULL,NULL),(10,1,'user5','123','ACT',NULL,'2018-05-31 04:50:02',NULL,NULL),(11,1,'admin','123','ACT',NULL,'2018-05-31 10:57:02',NULL,NULL),(12,6,'ptuya','123','ACT',NULL,'2018-05-31 10:57:02',NULL,NULL),(13,1,'usr1','123','ACT',NULL,'2018-05-31 12:54:02',NULL,NULL),(14,1,'vende1','123','ACT',NULL,'2018-05-31 12:54:02',NULL,NULL),(15,1,'user6','123','ACT',NULL,'2018-05-31 03:17:02',NULL,NULL),(16,6,'pawpaw','paw','ACT',NULL,'2018-06-18 19:08:02',NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seg_usuario_rol`
--

LOCK TABLES `seg_usuario_rol` WRITE;
/*!40000 ALTER TABLE `seg_usuario_rol` DISABLE KEYS */;
INSERT INTO `seg_usuario_rol` VALUES (3,1,3,'ACT',NULL,'2018-05-30 20:41:42'),(4,2,3,'ACT',NULL,'2018-05-30 20:41:42'),(5,3,4,'ACT',NULL,'2018-05-30 20:41:42'),(6,4,2,'ACT',NULL,'2018-05-30 16:17:42'),(7,5,5,'ACT',NULL,'2018-05-30 17:36:42'),(8,6,3,'ACT',NULL,'2018-05-31 04:52:42'),(9,7,5,'ACT',NULL,'2018-05-31 04:52:42'),(10,8,5,'ACT',NULL,'2018-05-31 04:52:42'),(11,9,5,'ACT',NULL,'2018-05-31 04:52:42'),(12,10,5,'ACT',NULL,'2018-05-31 04:52:42'),(13,11,2,'ACT',NULL,'2018-05-31 10:57:02'),(14,12,1,'ACT',NULL,'2018-05-31 10:57:02'),(15,13,5,'ACT',NULL,'2018-05-31 12:54:02'),(16,14,6,'ACT',NULL,'2018-05-31 12:54:02'),(17,15,5,'ACT',NULL,'2018-05-31 03:18:02'),(18,3,7,'ACT',NULL,'2018-06-17 17:39:34'),(19,16,5,'ACT',NULL,'2018-06-18 19:11:34');
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
  `FECHA_TRANSACCION` date NOT NULL,
  `ESTADO` int(11) NOT NULL,
  `ACTIVO` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID_LISTA_PRODUCCION`,`ID_PEDIDO`),
  KEY `ID_PEDIDO_TRANSAC_idx` (`ID_PEDIDO`)
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
-- Table structure for table `ven_boleta`
--

DROP TABLE IF EXISTS `ven_boleta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_boleta` (
  `idven_boleta` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_pedido` int(11) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `id_venta` int(11) DEFAULT NULL,
  PRIMARY KEY (`idven_boleta`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_boleta`
--

LOCK TABLES `ven_boleta` WRITE;
/*!40000 ALTER TABLE `ven_boleta` DISABLE KEYS */;
INSERT INTO `ven_boleta` VALUES (1,'2013-09-23',3,NULL,69.00,NULL,9);
/*!40000 ALTER TABLE `ven_boleta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_cliente`
--

DROP TABLE IF EXISTS `ven_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_cliente` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_cliente`
--

LOCK TABLES `ven_cliente` WRITE;
/*!40000 ALTER TABLE `ven_cliente` DISABLE KEYS */;
INSERT INTO `ven_cliente` VALUES (1,1),(2,1),(3,0),(4,0),(5,0),(6,0),(7,1),(8,0),(9,0),(10,1),(11,0),(12,0),(13,1),(14,1),(15,1);
/*!40000 ALTER TABLE `ven_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_cliente_juridico`
--

DROP TABLE IF EXISTS `ven_cliente_juridico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_cliente_juridico` (
  `ID_CLIENTE` int(5) NOT NULL,
  `RAZON_SOCIAL` varchar(70) NOT NULL,
  `RUC` int(8) NOT NULL,
  `GIRO_NEGOCIO` varchar(20) NOT NULL,
  `DIRECCION` varchar(150) NOT NULL,
  `TELEFONO` varchar(15) NOT NULL,
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
INSERT INTO `ven_cliente_juridico` VALUES (1,'Mecanica El Paw',69696969,'Mecanica','Av. el Paw 666','98989898','paw@paw.es','2018-05-24','admin',1),(2,'Frenos Panchito',12345678,'Servicios Mecanicos','Av. Los Ingenieros 991','987654300','fake_corporativo@email.com','2018-05-24','admin',1),(7,'Mecanica El Paw',42042042,'Electrica','Av. el Paw 456','051-423-4512','paw@paw.com','2018-05-24','admin',1),(10,'Poleas EIRL',57878546,'Metal-Mecanica','Av. Poleas 445','564564654','poleas@poleas.com','2018-06-14','admin',1),(13,'blablab',341414,'coso','cosososososo','3434','a@a.a','0000-00-00','admin',1),(14,'a',1,'sa','adfaf','987654321','a@a.a','2018-06-19','admin',1),(15,'a',134314,'adfaf','dafadf','987654321','a@a.a','2018-06-19','admin',1);
/*!40000 ALTER TABLE `ven_cliente_juridico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_cliente_natural`
--

DROP TABLE IF EXISTS `ven_cliente_natural`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_cliente_natural` (
  `ID_CLIENTE` int(5) NOT NULL,
  `NOMBRE` varchar(50) NOT NULL,
  `APELLIDO_P` varchar(25) NOT NULL,
  `APELLIDO_M` varchar(25) NOT NULL,
  `DNI` int(8) NOT NULL,
  `SEXO` tinyint(1) NOT NULL,
  `DIRECCION` varchar(150) NOT NULL,
  `TELEFONO` varchar(15) NOT NULL,
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
INSERT INTO `ven_cliente_natural` VALUES (3,'Carlos','Torrico','Menendez',79481293,1,'Av. Los Fresnos 342','948517328','fake@email.com','2018-05-24','admin',1),(4,'Daniela','Torrico','Menendez',79481293,0,'Av. Los Fresnos 342','948517328','fake2@email.com','2018-05-24','admin',1),(5,'Danilo','Marticorena','Jimenez',49302819,1,'Av. Las Acacias 666','984758373','fake3@email.com','2018-05-24','admin',1),(6,'Carlos','Quispe','Quispe',71255555,1,'Av. San Luis 222','968686562','a@a.com','2018-05-24','admin',1),(8,'Christopher','Morbihan','Díaz',68123941,1,'Av. Bretaña 951','941323533','cmorb@ebretagne.com','2018-06-14','admin',1),(9,'Charlotte','Paez','Menendez',45935134,0,'Av. Los Feiks 951','958315317','feik@hotmail.com','2018-06-14','admin',1),(11,'Camila','Gallardo','Barrientos',85341234,0,'Av. El Patardo 451','967-612-313','cgallardob@gmail.com','2018-06-19','admin',1),(12,'f','f','f',1,1,'ff','912-345-612','pawpaw@paw.paw','2018-06-19','admin',1);
/*!40000 ALTER TABLE `ven_cliente_natural` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ven_factura`
--

DROP TABLE IF EXISTS `ven_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ven_factura` (
  `id` int(11) NOT NULL,
  `ruc` int(11) DEFAULT NULL,
  `igv` decimal(10,2) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_venta` int(11) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_factura`
--

LOCK TABLES `ven_factura` WRITE;
/*!40000 ALTER TABLE `ven_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `ven_factura` ENABLE KEYS */;
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
  KEY `REL_7` (`id_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_linea_venta`
--

LOCK TABLES `ven_linea_venta` WRITE;
/*!40000 ALTER TABLE `ven_linea_venta` DISABLE KEYS */;
INSERT INTO `ven_linea_venta` VALUES (1,7,8,3),(2,7,2,1),(3,8,8,2),(4,8,2,1),(5,9,2,3),(6,9,3,3),(7,10,2,4),(8,11,3,2),(9,11,8,1),(10,12,2,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_pedido_almacen`
--

LOCK TABLES `ven_pedido_almacen` WRITE;
/*!40000 ALTER TABLE `ven_pedido_almacen` DISABLE KEYS */;
INSERT INTO `ven_pedido_almacen` VALUES (1,3,'En transporte','2018-05-31','admin',1);
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
  `concepto_descuento` varchar(100) DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `id_user_registro` bigint(15) DEFAULT NULL,
  `es_activo` bigint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ven_ventas`
--

LOCK TABLES `ven_ventas` WRITE;
/*!40000 ALTER TABLE `ven_ventas` DISABLE KEYS */;
INSERT INTO `ven_ventas` VALUES (1,2,'Confirmado',0.15000,'Cliente frecuente','2018-05-24 00:00:00',0,1),(7,8,'Confirmado',0.00000,'','2018-06-14 00:00:00',0,1),(8,8,'Registrado',0.10000,'Cliente especial','2018-06-14 00:00:00',0,1),(9,3,'Registrado',0.00000,'','2018-06-14 00:00:00',0,1),(10,6,'Registrado',0.00000,'','2018-06-14 00:00:00',0,1),(11,6,'Registrado',0.00000,'poco elegante','2018-06-14 00:00:00',0,1),(12,6,'Confirmado',0.00000,'','2018-06-14 00:00:00',0,1);
/*!40000 ALTER TABLE `ven_ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'inf282g2b'
--

--
-- Dumping routines for database 'inf282g2b'
--
/*!50003 DROP PROCEDURE IF EXISTS `actualizar_lista_de_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `actualizar_lista_de_produccion`(
					IN codigo INT
)
BEGIN
	SELECT ADPP.idPedidoProduccion AS 'ID_PEDIDO', ADPP.idProductoPedido AS 'ID_PRODUCTO', 
    ADPP.cantidadPedida AS 'CANTIDAD_PEDIDA', ADPP.activo AS 'ACTIVO' FROM prod_listas_de_produccion PLP 
    INNER JOIN prod_lista_pedidos LP ON PLP.ID_LISTA_PEDIDOS = LP.ID_LISTA_PEDIDOS INNER JOIN alm_detalle_pedido_a_produccion ADPP ON ADPP.idPedidoProduccion=LP.ID_PEDIDO WHERE PLP.ACTIVO=1 AND PLP.ID_LISTA_DE_PRODUCCION=codigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `actualizar_pedido_de_almacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `actualizar_pedido_de_almacen`(
					IN _id_pedido INT,
					IN _id_producto INT
)
BEGIN
	UPDATE alm_detalle_pedido_a_produccion SET activo=1 WHERE idPedidoProduccion=_id_pedido AND idProductoPedido=_id_producto;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `actualizar_pedido_de_almacen_como_parcialmente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `actualizar_pedido_de_almacen_como_parcialmente`(
					IN _id_pedido INT,
					IN _id_producto INT
)
BEGIN
	UPDATE alm_detalle_pedido_a_produccion SET activo=3 WHERE idPedidoProduccion=_id_pedido AND idProductoPedido=_id_producto;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_actualizar_habilitado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_actualizar_habilitado`(
	_id_almacen INT,
    _nuevo_habilitado TINYINT
)
BEGIN
	UPDATE alm_almacen
    SET habilitado = _nuevo_habilitado
    WHERE idAlmacen = _id_almacen;
    
    UPDATE alm_usuario_almacen
    SET habilitado = _nuevo_habilitado
    WHERE idAlmacen = _id_almacen;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_actualizar_stock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `alm_buscarProductoIdNombre` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_buscarProductoIdNombre`(
	_idAlmacen int,
    _idProd int,
	_nombre varchar(100)
)
BEGIN
	SELECT * FROM prod_productos
    WHERE (activo = 1) AND (id_producto = _idProd) AND (nombre LIKE concat('%',_nombre,'%')) AND ( id_producto NOT IN (SELECT Producto_idProducto 
																														FROM alm_producto_almacen 
																														WHERE Almacen_idAlmacen = _idAlmacen) );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_buscarProductoNombre` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_buscarProductoNombre`(
	_idAlmacen int,
	_nombre varchar(100)
)
BEGIN
	SELECT * FROM prod_productos
    WHERE (activo = 1) AND (nombre LIKE concat('%',_nombre,'%')) AND ( id_producto NOT IN (SELECT Producto_idProducto 
												FROM alm_producto_almacen 
												WHERE Almacen_idAlmacen = _idAlmacen) );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_buscar_productosAlmacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_buscar_productosAlmacen`(
	_id_almacen int,
    _nombreBuscar varchar(100),
    _limInferior int,
    _limSuperior int
    )
BEGIN
	SELECT id_producto,nombre,descripcion,precio_venta,cantidadAlmacenada
	FROM alm_producto_almacen INNER JOIN prod_productos ON Producto_idProducto = id_producto
	WHERE (Almacen_idAlmacen = _id_almacen) and (cantidadAlmacenada between _limInferior and _limSuperior) and (prod_productos.nombre LIKE concat('%',_nombreBuscar,'%'));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_buscar_productosAlmacenId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_buscar_productosAlmacenId`(
	_idProd int,
	_id_almacen int,
    _nombreBuscar varchar(100),
    _limInferior int,
    _limSuperior int
    )
BEGIN
	SELECT id_producto,nombre,descripcion,precio_venta,cantidadAlmacenada
	FROM alm_producto_almacen INNER JOIN prod_productos ON Producto_idProducto = id_producto
	WHERE (Almacen_idAlmacen = _id_almacen) AND (id_producto = _idProd) AND (cantidadAlmacenada BETWEEN _limInferior AND _limSuperior) AND (prod_productos.nombre LIKE concat('%',_nombreBuscar,'%'));
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_loguear_usuario`(
	IN _usuario varchar(200),
    IN _contrasena varchar(80),
    OUT _ingresoCorrecto bool,
    OUT _rol int,
    OUT _cantidadAlmacenes int,
    OUT _nombre varchar(150)
)
BEGIN
	DECLARE _idUsuario int DEFAULT -1;
    DECLARE _rolPrev int DEFAULT -1;
    DECLARE _ingresoPrev boolean DEFAULT FALSE; #indica si el usuario y contraseña son correctos
	DECLARE _cantAlmacenesPrev int DEFAULT -1;
    DECLARE _idPersona int DEFAULT -1;
    
	#Se verifica su registro
    SELECT id,id_persona INTO _idUsuario,_idPersona FROM seg_usuario WHERE usuario = _usuario AND clave = _contrasena AND estado = 'ACT';
    
    IF (_idUsuario>0) THEN
		BEGIN
			#se obtiene el nombre de la persona
            SELECT CONCAT(nombres," ",paterno) INTO _nombre FROM gen_persona WHERE id=_idPersona;
			#se obtiene el rol del usuario
			SELECT id_rol into _rolPrev FROM seg_usuario_rol WHERE id_usuario = _idUsuario AND estado = 'ACT';
            
            IF (_rolPrev>0) THEN
				set _ingresoPrev := TRUE;
			END IF;
            #se verifica que el rol corresponda a alguien de almacen
            #Jefe de Almacen
            IF (_rolPrev=2) THEN
				BEGIN
                    SELECT COUNT(*) INTO _cantAlmacenesPrev FROM alm_usuario_almacen WHERE idUsuario = _idUsuario AND habilitado = 1;
				END;
			#Usuario de Almacen
            ELSEIF (_rolPrev=5) THEN
				BEGIN
                    SELECT COUNT(*) INTO _cantAlmacenesPrev FROM alm_usuario_almacen WHERE idUsuario = _idUsuario AND habilitado = 1;
                    #se muestra todos los almacenes en los que se encuentra registrado el usuario
					SELECT alm_almacen.idAlmacen,alm_almacen.direccion,alm_almacen.telefono
						FROM alm_usuario_almacen
                        INNER JOIN alm_almacen ON alm_usuario_almacen.idAlmacen = alm_almacen.idAlmacen
									AND alm_almacen.habilitado=1 AND alm_usuario_almacen.idUsuario = _idUsuario;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_almacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_almacen`(
	IN _direccion VARCHAR(256),
    IN _telefono VARCHAR(20),
    OUT _id_salida INT
)
BEGIN
	INSERT INTO alm_almacen(direccion,telefono,habilitado,fk_idArea)
    VALUES(_direccion,_telefono,1,1);
    
    SET _id_salida = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_detalle_pedido_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_detalle_pedido_produccion`(
	IN _id_pedido_produccion INT,
    IN _id_producto INT,
    IN _cantidad INT,
    IN _observaciones VARCHAR(256),
    OUT _id_detalle_pedido INT
)
BEGIN
	INSERT INTO alm_detalle_pedido_a_produccion(idPedidoProduccion, idProductoPedido, cantidadPedida,observaciones)
    VALUES (_id_pedido_produccion,_id_producto,_cantidad,_observaciones);
    SET _id_detalle_pedido = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_ingreso_producto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_ingreso_producto`(
	in _id_area_origen int,
    in _id_sede_origen int,
    in _id_almacen_destino int,
    in _observaciones varchar(256),
    out _id_ingreso int
)
BEGIN
	SET time_zone = '-10:00';
	INSERT INTO alm_ingresos_y_salidas(id_area_origen,id_sede_origen,id_area_destino,
			id_sede_destino,observaciones,fecha_creacion,fecha_modificacion,habilitado)
    VALUES (_id_area_origen,_id_sede_origen,1,_id_almacen_destino,_observaciones,now(),now(),1);
    SET _id_ingreso = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_ingreso_salida_general` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_ingreso_salida_general`(
	IN _area_origen INT,
    IN _sede_origen INT,
    IN _area_destino INT,
    IN _sede_destino INT,
    IN _observaciones VARCHAR(256),
    OUT _id_movimiento INT
)
BEGIN
	INSERT INTO alm_ingresos_y_salidas(id_area_origen,id_sede_origen,id_area_destino,id_sede_destino,observaciones)
    VALUES (_area_origen,_sede_origen,_area_destino,_sede_destino,_observaciones);
    
    SET _observaciones = last_insert_id();
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_linea_ingreso` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_linea_ingreso`(
	IN _id_ingreso_producto INT,
    IN _id_producto INT,
    IN _cantidad INT,
    IN _observaciones VARCHAR(256),
    OUT _id_linea_ingreso INT
)
BEGIN
	DECLARE _ID_ALMACEN INT;
	
	INSERT INTO alm_linea_ingreso(id_movimiento,id_producto,cantidad,observaciones)
    VALUES (_id_ingreso_producto,_id_producto,_cantidad,_observaciones);
    SET _id_linea_ingreso = last_insert_id();
    
    SELECT id_sede_destino INTO _ID_ALMACEN
    FROM alm_ingresos_y_salidas WHERE id_movimiento = _id_ingreso_producto;
    
    UPDATE alm_producto_almacen
    SET cantidadAlmacenada = cantidadAlmacenada + _cantidad
    WHERE Almacen_idAlmacen = _ID_ALMACEN AND
    Producto_idProducto = _id_producto;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_linea_salida` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_linea_salida`(
	IN _id_salida INT,
    IN _id_producto INT,
    IN _cantidad INT,
    IN _observaciones VARCHAR(256),
    OUT _id_linea_salida INT
)
BEGIN
	DECLARE _ID_ALMACEN INT;
    
    INSERT INTO alm_linea_salida(id_movimiento,id_producto,cantidad,observaciones)
    VALUES (_id_salida,_id_producto,_cantidad,_observaciones);
    SET _id_linea_salida = last_insert_id();
    
    SELECT id_sede_origen INTO _ID_ALMACEN
    FROM alm_ingresos_y_salidas WHERE id_movimiento = _id_salida;
    
    UPDATE alm_producto_almacen
    SET cantidadAlmacenada = cantidadAlmacenada - _CANTIDAD
    WHERE Almacen_idAlmacen = _ID_ALMACEN AND
    Producto_idProducto = _id_producto;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_pedido_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_pedido_produccion`(
	in _id_almacen int,
    out id_pedido int
)
BEGIN
	INSERT INTO alm_pedido_a_produccion
		(ID_ALMACEN,ACTIVO)
	VALUES(_id_almacen,1);
    SET id_pedido = last_insert_id();
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `alm_registrar_salida_producto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `alm_registrar_salida_producto`(
	in _id_almacen_origen int,
    in _id_area_destino int,
    in _id_sede_destino int,
    in _observaciones varchar(256),
    out _id_salida int
)
BEGIN
	SET time_zone = '-10:00';
	INSERT INTO alm_ingresos_y_salidas(id_area_origen,id_sede_origen,id_area_destino,
			id_sede_destino,observaciones,fecha_creacion,fecha_modificacion,habilitado)
    VALUES (1,_id_almacen_origen,_id_area_destino,_id_sede_destino,_observaciones,now(),now(),1);
    SET _id_salida = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `anular_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `anular_venta`(IN `_id_venta` INT)
BEGIN
	update ven_ventas set es_activo=0, estado= 'anulado' where id=_id_venta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_cliente_juridico` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_cliente_juridico`(in _id_cliente int)
BEGIN
	update ven_cliente_juridico
    set ACTIVO = 0
    where ID_CLIENTE = _id_cliente;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_cliente_natural` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_cliente_natural`(in _id_cliente int)
BEGIN
	update ven_cliente_natural
    set ACTIVO = 0
    where ID_CLIENTE = _id_cliente;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_linea_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_linea_venta`(in _id_venta bigint, in _id_producto bigint)
BEGIN
	update ven_linea_venta
    set cantidad = 0
    where id_venta = _id_venta and id_producto = _id_producto;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_lista_de_pre_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_lista_de_pre_produccion`(
					IN _id_lista_de_pre_produccion INT
)
BEGIN
	UPDATE prod_listas_de_produccion SET ACTIVO = 0 WHERE ID_LISTA_DE_PRODUCCION=_id_lista_de_pre_produccion;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_pedido_de_lista_de_pre_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_pedido_de_lista_de_pre_produccion`(
					IN _id_lista_de_pre_produccion INT,
					IN _id_pedido INT
)
BEGIN
    declare id_lista_pedidos int;
    
    SELECT PLP.ID_LISTA_PEDIDOS INTO id_lista_pedidos FROM prod_listas_de_produccion PLP WHERE PLP.ID_LISTA_DE_PRODUCCION=_id_lista_de_pre_produccion;
    
    delete from prod_lista_pedidos where ID_PEDIDO=_id_pedido;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `eliminar_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `eliminar_venta`(in _id_venta bigint)
BEGIN
	update ven_ventas
    set es_activo = 0
    where id = _id_venta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_boleta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_boleta`(in _id_cliente int,	
                                    in _total decimal(10,2),
                                    in _estado tinyint,
                                    out _id_boleta int)
BEGIN
	insert into ven_boleta (id_cliente, total, estado)
    values(_id_cliente, _total, _estado);
    set _id_boleta = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_cliente_juridico` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_cliente_juridico`(in _razon_social varchar(70),
											in _ruc int,
											in _giro_negocio varchar(20),
											in _direccion varchar(150),
											in _telefono varchar(15),
											in _correo varchar(40),
											in _fecha_registro date,
											in _usuario_registro varchar(35),
											in _activo tinyint,
											out _id_cliente int)
BEGIN
	insert into ven_cliente (TIPO)
	values (1);
	set _id_cliente = last_insert_id();
	insert into ven_cliente_juridico (ID_CLIENTE, RAZON_SOCIAL, RUC, GIRO_NEGOCIO, DIRECCION, TELEFONO, CORREO, FECHA_REGISTRO, USUARIO_REGISTRO, ACTIVO)
	values (_id_cliente, _razon_social, _ruc, _giro_negocio, _direccion, _telefono, _correo, _fecha_registro, _usuario_registro, _activo);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_cliente_natural` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_cliente_natural`(in _nombre varchar(50),
											in _apellido_p  varchar(25),
											in _apellido_m varchar(25),
											in _dni int,
											in _sexo tinyint,
											in _direccion varchar(150),
											in _telefono varchar(15),
											in _correo varchar(35),
											in _fecha_registro date,
											in _usuario_registro varchar(30),
											in _activo tinyint,
											out _id_cliente int)
BEGIN
	insert into ven_cliente (TIPO)
    values (0);
	set _id_cliente = last_insert_id();
	insert into ven_cliente_natural (ID_CLIENTE, NOMBRE, APELLIDO_P, APELLIDO_M, DNI, SEXO, DIRECCION, TELEFONO, CORREO, FECHA_REGISTRO, USUARIO_REGISTRO, ACTIVO)
	values (_id_cliente, _nombre, _apellido_p, _apellido_m, _dni, _sexo, _direccion, _telefono, _correo, _fecha_registro, _usuario_registro, _activo);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_detalle_de_lista_de_pre_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_detalle_de_lista_de_pre_produccion`(
					IN _id_detalle_lista_produccion_flag INT,
					IN _id_producto INT,
                    IN _cantidad_solicitada DECIMAL(10,2),
                    OUT _id_detalle_lista_produccion INT
)
BEGIN
	declare _fecha timestamp default current_timestamp;

	if _id_detalle_lista_produccion_flag = -1 then
		insert into prod_detalles_lista_produccion (ID_PRODUCTO,CANTIDAD_SOLICITADA,ACTIVO)
        values (_id_producto,_cantidad_solicitada,1);
        set _id_detalle_lista_produccion=last_insert_id();
	else
		insert into prod_detalles_lista_produccion (ID_DETALLE_LISTA_PRODUCCION,ID_PRODUCTO,CANTIDAD_SOLICITADA,ACTIVO)
        values (_id_detalle_lista_produccion_flag,_id_producto,_cantidad_solicitada,1);
        set _id_detalle_lista_produccion=_id_detalle_lista_produccion_flag;
    end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_linea_pedido` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_linea_pedido`(
in _id_venta bigint,
in _id_producto bigint,
in _cantidad bigint)
BEGIN
	insert into ven_linea_pedido_almacen(id_venta, id_producto, cantidad)
    values (_id_venta, _id_producto, _cantidad);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_linea_prod_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_linea_prod_venta`(
in _id_venta bigint,
in _id_producto bigint,
in _cantidad bigint)
BEGIN
	insert into ven_linea_venta(id_venta, id_producto, cantidad)
    values (_id_venta, _id_producto, _cantidad);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_lista_de_pre_produccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_lista_de_pre_produccion`(
					IN _id_local INT,
					IN _id_detalle_lista_produccion INT,
                    IN _id_lista_pedidos INT
)
BEGIN
	declare _fecha timestamp default current_timestamp;
    
    insert into prod_listas_de_produccion(ID_LOCAL,ID_DETALLE_LISTA_PRODUCCION,ID_LISTA_PEDIDOS,FECHA_CREACION,FECHA_MODIFICACION,ID_ESTADO,ACTIVO)
    values (_id_local,_id_detalle_lista_produccion,_id_lista_pedidos,_fecha,_fecha,4,1);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_lista_pedidos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_lista_pedidos`(
					IN _id_lista_pedidos_flag INT,
					IN _id_pedido INT,
                    OUT _id_lista_pedidos INT
)
BEGIN
	if _id_lista_pedidos_flag = -1 then
		insert into prod_lista_pedidos (ID_PEDIDO)
        values (_id_pedido);
        set _id_lista_pedidos=last_insert_id();
	else
		insert into prod_lista_pedidos (ID_LISTA_PEDIDOS,ID_PEDIDO)
        values (_id_lista_pedidos_flag,_id_pedido);
        set _id_lista_pedidos=_id_lista_pedidos_flag;
    end if;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_manivela`(
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DECIMAL(10,2),
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_perilla`(
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DECIMAL(10,2),
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_polea`(
					IN _nombre VARCHAR(100),
                    IN _descripcion VARCHAR(100),
                    IN _precio_venta DECIMAL(10,2),
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
    values (_id_polea,_id_tipo_canal,_diametro,_id_unidad_producto,_cantidad_canales);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertar_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `insertar_venta`(in _id_cliente bigint,
in _estado varchar(10),
in _descuento decimal,
in _concepto_descuento varchar(100),
in _fecha_registro datetime,
in _id_user_registro bigint,
in _es_activo bigint,
out _id_venta bigint)
BEGIN
	insert into ven_ventas(id_cliente, estado, descuento, concepto_descuento, fecha_registro, id_user_registro, es_activo)
	values(_id_cliente, _estado, _descuento , _concepto_descuento, _fecha_registro , _id_user_registro , _es_activo);
	set _id_venta = last_insert_id();
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `listar_areas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_areas`()
BEGIN
	SELECT * FROM gen_areas;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_boletas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_boletas`()
BEGIN
	select * from ven_boleta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_clientes_juridicos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_clientes_juridicos`()
BEGIN
	select * from ven_cliente_juridico;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_clientes_naturales` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_clientes_naturales`()
BEGIN
	select * from ven_cliente_natural;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_pedido_almacen_ventas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_pedido_almacen_ventas`()
BEGIN
	select * from ven_pedido_almacen;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_productos_almacen`(_idAlmacen int)
BEGIN
	SELECT id_producto,nombre,descripcion,precio_venta,cantidadAlmacenada
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `listar_productos_ventas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_productos_ventas`()
BEGIN
	select * from prod_productos;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `listar_ventas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `listar_ventas`()
BEGIN
	select * from ven_ventas;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `modificar_cliente_juridico` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modificar_cliente_juridico`(in _razon_social varchar(70),
											in _ruc int,
											in _giro_negocio varchar(20),
											in _direccion varchar(150),
											in _telefono varchar(15),
											in _correo varchar(40),
											in _activo tinyint,
											in _id_cliente int)
BEGIN
	update ven_cliente_juridico
    set RAZON_SOCIAL = _razon_social, RUC = _ruc, GIRO_NEGOCIO = _giro_negocio, DIRECCION = _direccion, TELEFONO = _telefono, CORREO = _correo, ACTIVO = _activo
    where ID_CLIENTE = _id_cliente;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `modificar_cliente_natural` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modificar_cliente_natural`(in _nombre varchar(50),
											in _apellido_p  varchar(25),
											in _apellido_m varchar(25),
											in _dni int,
											in _sexo tinyint,
											in _direccion varchar(150),
											in _telefono varchar(15),
											in _correo varchar(35),
											in _activo tinyint,
											in _id_cliente int)
BEGIN
	update ven_cliente
    set NOMBRE = _nombre, APELLIDO_P = _apellido_p, APELLIDO_M = _apellido_m, DNI = _dni, SEXO = _sexo, DIRECCION = _direccion, TELEFONO = _telefono, CORREO =  _correo, ACTIVO = _activo
    where ID_CLIENTE = _id_cliente;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `modif_estado_pedido` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modif_estado_pedido`(in _estado varchar(50), in _id_pedido int)
BEGIN
	update ven_pedido_almacen
    set ESTADO = _estado
    where ID_PEDIDO = _id_pedido;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `modif_estado_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `modif_estado_venta`(in _estado varchar(50), in _id_venta int)
BEGIN
	update ven_ventas
    set estado = _estado
    where id = _id_venta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `negar_pedido_de_almacen` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `negar_pedido_de_almacen`(
					IN _id_pedido INT,
					IN _id_producto INT
)
BEGIN
	UPDATE alm_detalle_pedido_a_produccion SET activo=2 WHERE idPedidoProduccion=_id_pedido AND idProductoPedido=_id_producto;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `obtener_lineas_de_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `obtener_lineas_de_venta`(in _id_venta bigint)
BEGIN
	select * from ven_linea_venta where id_venta = _id_venta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `obtener_lineas_pedido_venta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `obtener_lineas_pedido_venta`(in _id_venta int)
BEGIN
	select * from ven_linea_pedido_almacen where ID_VENTA = _id_venta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `prov_listar_insumos_por_proveedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `prov_listar_insumos_por_proveedor`(
	IN _idProveedor INT(15)
)
BEGIN
	select
		ip.id_insumo, i.codigo, i.nombre,  ip.estado
	from prov_insumo_proveedor ip
	left join prov_insumo i on i.id = ip.id_insumo
	where id_proveedor = _idProveedor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `prov_reg_proveedor_insumo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `prov_reg_proveedor_insumo`( 
    IN _idProveedor int(15),
    IN _idInsumo int(15),
    IN _estado varchar(100),
    IN _idUserRegsitro int(15)    
)
BEGIN

	declare _fecha timestamp default current_timestamp;
    
    INSERT INTO prov_insumo_proveedor
    (id_proveedor, id_insumo, estado, id_user_registro, fecha_registro)
    VALUES
    (_idProveedor, _idInsumo, _estado, _idUserRegsitro, _fecha)
    ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `prov_reg_proveedor_juridico` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `prov_reg_proveedor_juridico`( 
    OUT _idCompania int(15),
    OUT _idProveedor int(15),
    IN _razon varchar(100),
    IN _giro varchar(100),
    IN _ruc varchar(15),
    IN _telefono varchar(10),
    IN _celular varchar(10),
    IN _email varchar(50),
    IN _direccion varchar(100),
    IN _estado varchar(3),
    IN _idUserRegsitro int(15),
    IN _tipoProv bigint(15)
)
BEGIN

    INSERT INTO gen_compania
    (razon_social, giro_negocio, ruc, telefono, celular, email, direccion, estado, id_user_registro, fecha_registro)
    VALUES
    (_razon, _giro, _ruc, _telefono, _celular, _email, _direccion, _estado, _idUserRegsitro, SYSDATE())
    ;
    SET _idCompania = LAST_INSERT_ID();


    INSERT INTO prov_proveedor
    (id_compania, tipo_prov, estado, id_user_registro, fecha_registro)
    VALUES
    (_idCompania, _tipoProv, _estado, _idUserRegsitro, SYSDATE())
    ;
    SET _idProveedor = LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `prov_reg_proveedor_natural` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `prov_reg_proveedor_natural`( 
    OUT _idPersona int(15),
    OUT _idPersonaNatural int(15),
    OUT _idProveedor int(15),
    IN _nombres varchar(100),
    IN _paterno varchar(100),
    IN _materno varchar(100),
    IN _sexo varchar(1),
    IN _email varchar(100),
    IN _celular varchar(100),
    IN _telefono varchar(100),
    IN _idTipoDoc int(15),
    IN _numeroDoc varchar(10),
    IN _direccion varchar(100),
    IN _estado varchar(3),
    IN _idUserRegsitro int(15),
    IN _ruc varchar(11),
    IN _estadoNatural varchar(3),
    IN _tipoProv bigint(15),
    IN _estadoProv varchar(3)
)
BEGIN

    INSERT INTO gen_persona
    (nombres, paterno, materno, sexo, email, celular, telefono, id_tipo_doc_identidad, numero_doc_identidad, direccion, estado, id_user_registro, fecha_registro)
    VALUES
    (_nombres, _paterno, _materno, _sexo, _email, _celular, _telefono, _idTipoDoc, _numeroDoc, _direccion, _estado, _idUserRegsitro, SYSDATE())
    ;
    SET _idPersona = LAST_INSERT_ID();

    INSERT INTO prov_proveedor_natural
    (id_persona, ruc, estado, id_user_registro, fecha_registro)
    VALUES
    (_idPersona, _ruc, _estadoNatural, _idUserRegsitro, SYSDATE())
    ;
    SET _idPersonaNatural = LAST_INSERT_ID();

    INSERT INTO prov_proveedor
    (id_natural, tipo_prov, estado, id_user_registro, fecha_registro)
    VALUES
    (_idPersonaNatural, _tipoProv, _estadoProv, _idUserRegsitro, SYSDATE())
    ;
    SET _idProveedor = LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `prov_update_insumos_por_proveedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `prov_update_insumos_por_proveedor`(	
	IN _idInsumoProv INT(15),
    IN _estadoInsumo VARCHAR(15) ,
    IN _idUser INT(15)
)
BEGIN
	
    UPDATE prov_insumo_proveedor 
    SET 
			estado = _estadoInsumo,
            id_user_modifica = _idUser,
            fecha_modifica = SYSDATE()
	WHERE 
		id = _idInsumoProv
;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `prov_update_proveedor_natural` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `prov_update_proveedor_natural`( 
    IN _idPersona int(15),
    IN _idPersonaNatural int(15),
    IN _idProveedor int(15),
    IN _nombres varchar(100),
    IN _paterno varchar(100),
    IN _materno varchar(100),
    IN _sexo varchar(1),
    IN _email varchar(100),
    IN _celular varchar(100),
    IN _telefono varchar(100),
    IN _idTipoDoc int(15),
    IN _numeroDoc varchar(10),
    IN _direccion varchar(100),
    IN _estado varchar(3),
    IN _idUserRegistro int(15),
    IN _ruc varchar(11),
    IN _estadoNatural varchar(3),
    IN _tipoProv bigint(15),
    IN _estadoProv varchar(3)
)
BEGIN

    UPDATE gen_persona
	SET 
				  nombres = _nombres
				, paterno = _paterno
                , materno = _materno
                , sexo = _sexo
                , email = _email
                , celular = _celular
                , telefono = _telefono
                , id_tipo_doc_identidad = _idTipoDoc
                , numero_doc_identidad = _numeroDoc
                , direccion = _direccion
                , estado = _estado
                , id_user_modifica = _idUserRegistro
                , fecha_modifica = SYSDATE()
    WHERE 
				id = _idPersona
    ;
    
    UPDATE prov_proveedor_natural
    SET			  
              ruc = _ruc
            , estado = _estadoProv
            , id_user_modifica = _idUserRegistro
            , fecha_modifica =    SYSDATE()         
    WHERE
			id = _idPersonaNatural
    ;
    
    UPDATE prov_proveedor
    SET		              
		   estado = _estadoProv
         , id_user_modifica = _idUserRegistro
         , fecha_modifica = SYSDATE()
    WHERE
		id = _idProveedor
    ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ven_estadisticas_boleta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `ven_estadisticas_boleta`(out _cantidad int, out _minimo double, out _maximo double, out _promedio double)
BEGIN
	select count(total) as cantidad, min(total) as minimo, max(total) as maximo, avg(total) as promedio
    from ven_boleta;
    set _cantidad = cantidad;
    set _minimo = minimo;
    set _maximo = maximo;
    set _promedio = promedio;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ven_estadisticas_factura` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g2`@`%` PROCEDURE `ven_estadisticas_factura`(out _cantidad int, out _minimo double, out _maximo double, out _promedio double)
BEGIN
	select count(total) as _cantidad, min(total) as _minimo, max(total) as _maximo, avg(total) as _promedio
    from ven_factura;
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

-- Dump completed on 2018-06-19 20:31:11
