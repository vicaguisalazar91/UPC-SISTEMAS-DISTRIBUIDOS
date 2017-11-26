<?php
/**
 * Created by PhpStorm.
 * User: Vic Aguilar
 * Date: 26/11/2017
 * Time: 00:59
 */


defined('BASEPATH') OR exit('No direct script access allowed');

require_once APPPATH . '/libraries/REST_Controller.php';


class TeammemberSW extends REST_Controller
{

    function __construct()
    {
        parent::__construct();
        $this->load->model('Teammember_model');
    }

    /*
     * Listing of cliente
     */
    function index_get()
    {

        $Teammember = $this->Teammember_model->get_all_teammember();
        $this->response($Teammember, REST_Controller::HTTP_OK);
    }

    /*
     * finding of Cliente
     */
    function find_get($id)
    {
        $this->set_response($id, REST_Controller::HTTP_OK);

        if(!$id){
            $this->response([
                'status' => FALSE,
                'message' => 'No se encontró resultado.'
            ], REST_Controller::HTTP_NOT_FOUND);
        }

        $teammember = $this->Teammember_model->get_teammember($id);

        if(!is_null($teammember)){
            $this->set_response($teammember, REST_Controller::HTTP_OK);
        }else{
            $this->set_response([
                'status' => FALSE,
                'message' => 'Skier No encontrado'
            ], REST_Controller::HTTP_NOT_FOUND);
        }
    }

    /*
     * Deleting cliente
     */
    function index_delete($id)
    {

        // check if the cliente exists before trying to delete it
        if(!is_null($id))
        {
            $this->Teammember_model->delete_teammember($id);
            $message = [
                'id' => $id,
                'message' => 'Se elimino correctamente.'
            ];

            $this->set_response($message, REST_Controller::HTTP_NO_CONTENT);
        }
        else
            $this->response(NULL, REST_Controller::HTTP_BAD_REQUEST);

    }

}