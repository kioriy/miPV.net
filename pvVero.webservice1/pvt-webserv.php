<?php


	require_once "lib/config.php";
	require_once "lib/nusoap/nusoap.php";
	//include "lib/System.Clases.php";

	$ns="http://sanherti.com/pv/pvVero.webservice/";
	//$ns="http://localhost/pvVero.webservice/";
	//$ns="http://192.168.0.8/pvTerrenos.webservice/";

	$server = new soap_server();
	$server->configureWSDL('PVT',$ns);
	$server->wsdl->schemaTargetNamespace=$ns;

/*
* registro de las funciones del web service
*/

	$server->register('query',
		array('table' => 'xsd:string',
			  'values' => 'xsd:string',
			  'action' => 'xsd:string',
			  'where' => 'xsd:string'),
		array('return'=>'xsd:string'),$ns);


/* funciones del web service*/
include "lib/System.Methods.php";//metodo madre
/*fin de las funciones para los usuarios*/


if (!isset($HTTP_RAW_POST_DATA))
{
	$HTTP_RAW_POST_DATA = file_get_contents('php://input');
}

$server->service($HTTP_RAW_POST_DATA);

//$server->service($HTTP_RAW_POST_DATA);
?>
