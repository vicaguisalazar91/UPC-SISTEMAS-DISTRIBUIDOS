<?php
if (!defined('BASEPATH')) exit('No direct script access allowed');

class MySoapServer extends CI_Controller {

    function __construct() {
		error_reporting(E_ERROR);

        parent::__construct();
        $this->load->model('Federation_model'); //load your models here

        $this->load->library("Nusoap_lib"); //load the library here
        $this->nusoap_server = new soap_server();
        $this->nusoap_server->configureWSDL("MySoapServer", "urn:MySoapServer");
        $this->nusoap_server->register(
                "echoTest", array("tmp" => "xsd:string"), array("return" => "xsd:string"), "urn:MySoapServer", "urn:MySoapServer#echoTest", "rpc", "encoded", "Echo test"
        );
        $this->nusoap_server->register(
            "addFederation", array("FederationID" => "xsd:string","FederationName" => "xsd:string","FederatedNumber" => "xsd:string"), array("return" => "xsd:string"), "urn:MySoapServer", "urn:MySoapServer#addFederation", "rpc", "encoded", "add Federation"
        );

        /**
         * To test whether SOAP server/client is working properly
         * Just echos the input parameter
         * @param string $tmp anything as input parameter
         * @return string returns the input parameter
         */
        function echoTest($tmp) {
            if (!$tmp) {
                return new soap_fault('-1', 'Server', 'Parameters missing for echoTest().', 'Please refer documentation.');
            } else {
                return "from MySoapServer() : $tmp";
            }
        }

        function addFederation($FederationID,$FederationName,$FederatedNumber){

            $data = array(
                'FederationID' => $FederationID,'FederationName' => $FederationName,'FederatedNumber' => $FederatedNumber
            );

            $CI =& get_instance();
            $CI->load->model('Federation_model');



            if (empty($FederationID)|| empty($FederationName)) {
                return new soap_fault('-1', 'Server', 'Parameters missing for addFederation().', 'Please refer documentation.');
            }else{

                $response = $CI->Federation_model->addFederation($data);
                if($response){
                    return "TRUE";
                }else{
                    return "FALSE";
                }
            }
        }
		
		
    }

    function index() {
        $this->nusoap_server->service(file_get_contents("php://input")); //shows the standard info about service
    }
}