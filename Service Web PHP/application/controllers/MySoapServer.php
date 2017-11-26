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
        $this->nusoap_server->wsdl->schemaTargetNamespace = 'urn:MySoapServer';

        $this->nusoap_server->register(
                "echoTest", array("tmp" => "xsd:string"), array("return" => "xsd:string"), "urn:MySoapServer", "urn:MySoapServer#echoTest", "rpc", "encoded", "Echo test"
        );

        $this->nusoap_server->register(
            "addSkier", array("NumberId" => "xsd:string","SkierName" => "xsd:string","Birthdate" => "xsd:string","FederationID" => "xsd:string"), array("return" => "xsd:string"), "urn:MySoapServer", "urn:MySoapServer#addFederation", "rpc", "encoded", "add Federation"
        );

        $this->nusoap_server->register(
            "addTeamMember", array("TeamMemberId" => "xsd:string","TeamId" => "xsd:string","NumberId" => "xsd:string"), array("return" => "xsd:string"), "urn:MySoapServer", "urn:MySoapServer#addFederation", "rpc", "encoded", "add Federation"
        );

        $this->nusoap_server->register(
            "addTeam", array("TeamId" => "xsd:string","TeamName" => "xsd:string","CoachName" => "xsd:string","SkiersNumber" => "xsd:string"), array("return" => "xsd:string"), "urn:MySoapServer", "urn:MySoapServer#addFederation", "rpc", "encoded", "add Federation"
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

        function addSkier($NumberId,$SkierName,$Birthdate,$FederationID){

            $data = array(
                'NumberId' => $NumberId,'SkierName' => $SkierName,'Birthdate' => $Birthdate,'FederationID' => $FederationID
            );

            $CI =& get_instance();
            $CI->load->model('Skier_model');

            if (empty($SkierName)|| empty($Birthdate) || empty($FederationID)) {
                return new soap_fault('-1', 'Server', 'Parameters missing for addSkier().', 'Please refer documentation.');
            }
            else{

                $result = $CI->Skier_model->get_skier($NumberId);
                if(empty($result)){

                    $response = $CI->Skier_model->add_skier($data);

                    if(!empty($response)){
                        return "TRUE";
                    }else{
                        return "FALSE";
                    }

                }else{

                    $response = $CI->Skier_model->update_skier($NumberId,$data);

                    if(!empty($response)){
                        return "TRUE";
                    }else{
                        return "FALSE";
                    }
                }
            }

        }

        function addTeamMember($TeamMemberId,$TeamId,$NumberId){

            $data = array(
                'TeamMemberId' => $TeamMemberId,'TeamId' => $TeamId,'NumberId' => $NumberId
            );

            $CI =& get_instance();
            $CI->load->model('Teammember_model');

            if (empty($TeamMemberId)|| empty($TeamId) || empty($NumberId)) {
                return new soap_fault('-1', 'Server', 'Parameters missing for addTeamMember().', 'Please refer documentation.');
            }else{

                $result = $CI->Teammember_model->get_teammember($TeamMemberId);

                if(empty($result)){

                    $response = $CI->Teammember_model->add_teammember($data);

                    if(!empty($response)){
                        return "TRUE";
                    }else{
                        return "FALSE";
                    }

                }else{

                    $response = $CI->Teammember_model->update_teammember($TeamMemberId,$data);

                    if(!empty($response)){
                        return "TRUE";
                    }else{
                        return "FALSE";
                    }
                }
            }

        }

        function addTeam($TeamId,$TeamName,$CoachName,$SkiersNumber){

            $data = array(
                'TeamId' => $TeamId,'TeamName' => $TeamName,'CoachName' => $CoachName,'SkiersNumber' => $SkiersNumber
            );

            $CI =& get_instance();
            $CI->load->model('Team_model');

            if (empty($TeamId)|| empty($TeamName) || empty($CoachName) || empty($SkiersNumber)) {
                return new soap_fault('-1', 'Server', 'Parameters missing for addTeam().', 'Please refer documentation.');
            }else{

                $result = $CI->Team_model->get_team($TeamId);

                if(empty($result)){

                    $response = $CI->Team_model->add_team($data);

                    if(!empty($response)){
                        return "TRUE";
                    }else{
                        return "FALSE";
                    }

                }else{

                    $response = $CI->Team_model->update_team($TeamId,$data);

                    if(!empty($response)){
                        return "TRUE";
                    }else{
                        return "FALSE";
                    }
                }
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
				
				$result = $CI->Federation_model->get_federation($FederationID);
				
				if(empty($result)){
					
					$response = $CI->Federation_model->add_federation($data);
					
					if(!empty($response)){
						return "TRUE";
					}else{
						return "FALSE";
					}
					
				}else{
					
					$response = $CI->Federation_model->update_federation($FederationID,$data);
					
					if(!empty($response)){
						return "TRUE";
					}else{
						return "FALSE";
					}
				}
            }
        }
		
		
    }

    function index() {
        $this->nusoap_server->service(file_get_contents("php://input")); //shows the standard info about service
    }
}