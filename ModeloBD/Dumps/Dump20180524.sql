-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: a20151258
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.31-MariaDB

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
-- Table structure for table `ALM_ALMACEN`
--

DROP TABLE IF EXISTS `ALM_ALMACEN`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ALM_ALMACEN` (
  `idAlmacen` int(11) NOT NULL AUTO_INCREMENT,
  `habilitado` tinyint(4) NOT NULL,
  `LOCAL_idLOCAL` int(11) NOT NULL,
  PRIMARY KEY (`idAlmacen`),
  KEY `fk_ALM_ALMACEN_LOCAL1_idx` (`LOCAL_idLOCAL`),
  CONSTRAINT `fk_ALM_ALMACEN_LOCAL1` FOREIGN KEY (`LOCAL_idLOCAL`) REFERENCES `LOCAL` (`idLOCAL`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ALM_ALMACEN`
--

LOCK TABLES `ALM_ALMACEN` WRITE;
/*!40000 ALTER TABLE `ALM_ALMACEN` DISABLE KEYS */;
INSERT INTO `ALM_ALMACEN` VALUES (1,1,1),(2,1,3),(3,1,2),(4,1,5);
/*!40000 ALTER TABLE `ALM_ALMACEN` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ALM_INGRESO_PRODUCTO`
--

DROP TABLE IF EXISTS `ALM_INGRESO_PRODUCTO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ALM_INGRESO_PRODUCTO` (
  `idIngresoProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Almacen_idAlmacen` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  `idLocalEmisor` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`idIngresoProducto`),
  KEY `fk_IngresoProducto_Almacen1_idx` (`Almacen_idAlmacen`),
  KEY `fk_ALM_INGRESO_PRODUCTO_LOCAL1_idx` (`idLocalEmisor`),
  CONSTRAINT `fk_ALM_INGRESO_PRODUCTO_LOCAL1` FOREIGN KEY (`idLocalEmisor`) REFERENCES `LOCAL` (`idLOCAL`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_IngresoProducto_Almacen1` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `ALM_ALMACEN` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ALM_INGRESO_PRODUCTO`
--

LOCK TABLES `ALM_INGRESO_PRODUCTO` WRITE;
/*!40000 ALTER TABLE `ALM_INGRESO_PRODUCTO` DISABLE KEYS */;
INSERT INTO `ALM_INGRESO_PRODUCTO` VALUES (1,1,'2018-05-24 02:05:20',3,'Primer Ingreso'),(2,1,'2018-05-24 02:19:27',3,'OK. Se recupera todo'),(3,1,'2018-05-24 02:27:58',3,'OK'),(4,1,'2018-05-24 02:29:18',1,'');
/*!40000 ALTER TABLE `ALM_INGRESO_PRODUCTO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ALM_LINEA_INGRESO_PRODUCTO`
--

DROP TABLE IF EXISTS `ALM_LINEA_INGRESO_PRODUCTO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ALM_LINEA_INGRESO_PRODUCTO` (
  `idLineaIngresoProducto` int(11) NOT NULL AUTO_INCREMENT,
  `IngresoProducto_idIngresoProducto` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `cantidadIngreso` int(11) NOT NULL,
  `observaciones` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idLineaIngresoProducto`),
  KEY `fk_ALM_LINEA_INGRESO_PRODUCTO_IngresoProducto1_idx` (`IngresoProducto_idIngresoProducto`),
  KEY `fk_ALM_LINEA_INGRESO_PRODUCTO_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_ALM_LINEA_INGRESO_PRODUCTO_IngresoProducto1` FOREIGN KEY (`IngresoProducto_idIngresoProducto`) REFERENCES `ALM_INGRESO_PRODUCTO` (`idIngresoProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ALM_LINEA_INGRESO_PRODUCTO_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `PRODUCTO` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ALM_LINEA_INGRESO_PRODUCTO`
--

LOCK TABLES `ALM_LINEA_INGRESO_PRODUCTO` WRITE;
/*!40000 ALTER TABLE `ALM_LINEA_INGRESO_PRODUCTO` DISABLE KEYS */;
INSERT INTO `ALM_LINEA_INGRESO_PRODUCTO` VALUES (2,1,1,10,'1'),(3,1,4,40,'2'),(4,3,1,5,''),(5,3,4,10,''),(6,4,1,1,'');
/*!40000 ALTER TABLE `ALM_LINEA_INGRESO_PRODUCTO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ALM_LINEA_SALIDA_PRODUCTO`
--

DROP TABLE IF EXISTS `ALM_LINEA_SALIDA_PRODUCTO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ALM_LINEA_SALIDA_PRODUCTO` (
  `idLineaSalidaProducto` int(11) NOT NULL AUTO_INCREMENT,
  `SalidaProducto_idSalidaProducto` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `cantidadSalida` int(11) NOT NULL,
  `observaciones` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idLineaSalidaProducto`),
  KEY `fk_ALM_LINEA_SALIDA_PRODUCTO_SalidaProducto1_idx` (`SalidaProducto_idSalidaProducto`),
  KEY `fk_ALM_LINEA_SALIDA_PRODUCTO_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_ALM_LINEA_SALIDA_PRODUCTO_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `PRODUCTO` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ALM_LINEA_SALIDA_PRODUCTO_SalidaProducto1` FOREIGN KEY (`SalidaProducto_idSalidaProducto`) REFERENCES `ALM_SALIDA_PRODUCTO` (`idSalidaProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ALM_LINEA_SALIDA_PRODUCTO`
--

LOCK TABLES `ALM_LINEA_SALIDA_PRODUCTO` WRITE;
/*!40000 ALTER TABLE `ALM_LINEA_SALIDA_PRODUCTO` DISABLE KEYS */;
INSERT INTO `ALM_LINEA_SALIDA_PRODUCTO` VALUES (8,21,1,5,'Te mando la mitad'),(9,21,4,10,'Te mando 10'),(10,22,1,1,'');
/*!40000 ALTER TABLE `ALM_LINEA_SALIDA_PRODUCTO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ALM_PRODUCTO_ALMACEN`
--

DROP TABLE IF EXISTS `ALM_PRODUCTO_ALMACEN`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ALM_PRODUCTO_ALMACEN` (
  `Almacen_idAlmacen` int(11) NOT NULL,
  `Producto_idProducto` int(11) NOT NULL,
  `cantidadAlmacenada` int(11) NOT NULL,
  PRIMARY KEY (`Producto_idProducto`,`Almacen_idAlmacen`),
  KEY `fk_ProductoAlmacen_Producto1_idx` (`Producto_idProducto`),
  KEY `fk_ProductoAlmacen_Almacen` (`Almacen_idAlmacen`),
  CONSTRAINT `fk_ProductoAlmacen_Almacen` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `ALM_ALMACEN` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProductoAlmacen_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `PRODUCTO` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ALM_PRODUCTO_ALMACEN`
--

LOCK TABLES `ALM_PRODUCTO_ALMACEN` WRITE;
/*!40000 ALTER TABLE `ALM_PRODUCTO_ALMACEN` DISABLE KEYS */;
INSERT INTO `ALM_PRODUCTO_ALMACEN` VALUES (1,1,10),(1,4,40),(4,4,44);
/*!40000 ALTER TABLE `ALM_PRODUCTO_ALMACEN` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ALM_SALIDA_PRODUCTO`
--

DROP TABLE IF EXISTS `ALM_SALIDA_PRODUCTO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ALM_SALIDA_PRODUCTO` (
  `idSalidaProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Almacen_idAlmacen` int(11) NOT NULL,
  `fechaSalida` datetime NOT NULL,
  `idLocalDestino` int(11) DEFAULT NULL,
  `estadoEnvio` int(11) NOT NULL,
  `observaciones` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`idSalidaProducto`),
  KEY `fk_SalidaProducto_Almacen1_idx` (`Almacen_idAlmacen`),
  KEY `fk_ALM_SALIDA_PRODUCTO_LOCAL1_idx` (`idLocalDestino`),
  CONSTRAINT `fk_SalidaProducto_Almacen1` FOREIGN KEY (`Almacen_idAlmacen`) REFERENCES `ALM_ALMACEN` (`idAlmacen`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ALM_SALIDA_PRODUCTO`
--

LOCK TABLES `ALM_SALIDA_PRODUCTO` WRITE;
/*!40000 ALTER TABLE `ALM_SALIDA_PRODUCTO` DISABLE KEYS */;
INSERT INTO `ALM_SALIDA_PRODUCTO` VALUES (21,1,'2018-05-24 02:18:19',2,1,'OK'),(22,1,'2018-05-24 02:29:51',1,1,'');
/*!40000 ALTER TABLE `ALM_SALIDA_PRODUCTO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `LOCAL`
--

DROP TABLE IF EXISTS `LOCAL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `LOCAL` (
  `idLOCAL` int(11) NOT NULL AUTO_INCREMENT,
  `telefonoLOCAL` varchar(15) NOT NULL,
  `direccionLOCAL` varchar(128) NOT NULL,
  PRIMARY KEY (`idLOCAL`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `LOCAL`
--

LOCK TABLES `LOCAL` WRITE;
/*!40000 ALTER TABLE `LOCAL` DISABLE KEYS */;
INSERT INTO `LOCAL` VALUES (1,'111-1111','Direccion del local1'),(2,'222-2222','Direccion del local 2'),(3,'333-3333','Direccion del local 3'),(4,'444444444','Direccion del local 4'),(5,'555555555','Direccion del local 4');
/*!40000 ALTER TABLE `LOCAL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PRODUCTO`
--

DROP TABLE IF EXISTS `PRODUCTO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `PRODUCTO` (
  `idProducto` int(11) NOT NULL,
  `codProducto` varchar(10) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `habilitado` tinyint(4) NOT NULL,
  `descripcionProd` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PRODUCTO`
--

LOCK TABLES `PRODUCTO` WRITE;
/*!40000 ALTER TABLE `PRODUCTO` DISABLE KEYS */;
INSERT INTO `PRODUCTO` VALUES (1,'Prod1','Producto 1',1,'Polea 1'),(2,'Prod2','Producto 2',1,'Polea 2'),(3,'Prod3','Producto 3',1,'Polea 3'),(4,'Prod4','Producto 4',1,'Cadena 1'),(5,'Prod5','Producto 5',1,'Cadena 2');
/*!40000 ALTER TABLE `PRODUCTO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'a20151258'
--

--
-- Dumping routines for database 'a20151258'
--
/*!50003 DROP PROCEDURE IF EXISTS `ACTUALIZAR_STOCK` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `ACTUALIZAR_STOCK`(
	_ID_ALMACEN  INT,
	_ID_PRODUCTO INT,
    _NUEVO_STOCK INT
)
BEGIN
	UPDATE ALM_PRODUCTO_ALMACEN
    SET CANTIDADALMACENADA = _NUEVO_STOCK
    WHERE ALMACEN_IDALMACEN = _ID_ALMACEN AND
    PRODUCTO_IDPRODUCTO = _ID_PRODUCTO;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_INGRESO_PRODUCTO_ALMACEN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `REGISTRAR_INGRESO_PRODUCTO_ALMACEN`(
	IN _ID_ALMACEN INT,
    IN _ID_LOCAL_EMITE INT,
    IN _OBSERVACIONES VARCHAR(256),
    OUT _ID_INGRESO INT
)
BEGIN
	SET time_zone = '-10:00';
	INSERT INTO ALM_INGRESO_PRODUCTO(Almacen_idAlmacen,fechaIngreso,idLocalEmisor,observaciones)
    VALUES (_ID_ALMACEN,NOW(),_ID_LOCAL_EMITE,_OBSERVACIONES);
    SET _ID_INGRESO = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_LINEA_INGRESO_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `REGISTRAR_LINEA_INGRESO_PRODUCTO`(
	IN _ID_INGRESO_PRODUCTO INT,
    IN _ID_PRODUCTO INT,
    IN _CANTIDAD INT,
    IN _OBSERVACIONES VARCHAR(256),
    OUT _ID_LINEA_INGRESO INT
)
BEGIN
	DECLARE _ID_ALMACEN INT;
	
	INSERT INTO ALM_LINEA_INGRESO_PRODUCTO(IngresoProducto_idIngresoProducto,Producto_idProducto,cantidadIngreso,observaciones)
    VALUES (_ID_INGRESO_PRODUCTO,_ID_PRODUCTO,_CANTIDAD,_OBSERVACIONES);
    SET _ID_LINEA_INGRESO = last_insert_id();
    
    SELECT Almacen_idAlmacen INTO _ID_ALMACEN
    FROM ALM_INGRESO_PRODUCTO WHERE idIngresoProducto = _ID_INGRESO_PRODUCTO;
    
    UPDATE ALM_PRODUCTO_ALMACEN
    SET CANTIDADALMACENADA = CANTIDADALMACENADA + _CANTIDAD
    WHERE ALMACEN_IDALMACEN = _ID_ALMACEN AND
    PRODUCTO_IDPRODUCTO = _ID_PRODUCTO;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_LINEA_SALIDA_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `REGISTRAR_LINEA_SALIDA_PRODUCTO`(
	IN _ID_SALIDA_PRODUCTO INT,
    IN _ID_PRODUCTO INT,
    IN _CANTIDAD INT,
    IN _OBSERVACIONES VARCHAR(256),
    OUT _ID_LINEA_SALIDA INT
)
BEGIN
	DECLARE _ID_ALMACEN INT;
    
    INSERT INTO ALM_LINEA_SALIDA_PRODUCTO(SalidaProducto_idSalidaProducto,Producto_idProducto,cantidadSalida,observaciones)
    VALUES (_ID_SALIDA_PRODUCTO,_ID_PRODUCTO,_CANTIDAD,_OBSERVACIONES);
    SET _ID_LINEA_SALIDA = last_insert_id();
    
    SELECT Almacen_idAlmacen INTO _ID_ALMACEN
    FROM ALM_SALIDA_PRODUCTO WHERE idSalidaProducto = _ID_SALIDA_PRODUCTO;
    
    UPDATE ALM_PRODUCTO_ALMACEN
    SET CANTIDADALMACENADA = CANTIDADALMACENADA - _CANTIDAD
    WHERE ALMACEN_IDALMACEN = _ID_ALMACEN AND
    PRODUCTO_IDPRODUCTO = _ID_PRODUCTO;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_PRODUCTO_ALMACEN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `REGISTRAR_PRODUCTO_ALMACEN`(
	_ID_PRODUCTO INT,
    _ID_ALMACEN INT,
    _STOCK_INICIAL INT
)
BEGIN
	INSERT INTO ALM_PRODUCTO_ALMACEN (ALMACEN_IDALMACEN,PRODUCTO_IDPRODUCTO,CANTIDADALMACENADA)
    VALUES (_ID_ALMACEN,_ID_PRODUCTO,_STOCK_INICIAL);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_SALIDA_PRODUCTO_ALMACEN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `REGISTRAR_SALIDA_PRODUCTO_ALMACEN`(
	IN _ID_ALMACEN_ENVIA INT,
    IN _ID_LOCAL_DEST INT,
    IN _OBSERVACIONES VARCHAR(256),
    OUT _ID_SALIDA INT
)
BEGIN
	SET time_zone = '-10:00';
	INSERT INTO ALM_SALIDA_PRODUCTO(Almacen_idAlmacen,fechaSalida,idLocalDestino,estadoEnvio,observaciones)
    VALUES (_ID_ALMACEN_ENVIA,NOW(),_ID_LOCAL_DEST,1,_OBSERVACIONES);
    SET _ID_SALIDA = last_insert_id();
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

-- Dump completed on 2018-05-24  2:33:29
