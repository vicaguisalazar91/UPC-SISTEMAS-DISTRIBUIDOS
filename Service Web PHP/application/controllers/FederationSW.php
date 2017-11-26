<?php
/**
 * Created by PhpStorm.
 * User: Vic Aguilar
 * Date: 25/11/2017
 * Time: 02:19
 */

defined('BASEPATH') OR exit('No direct script access allowed');

require_once APPPATH . '/libraries/REST_Controller.php';

class FederationSW extends REST_Controller
{

    function __construct()
    {
        parent::__construct();
        $this->load->model('Federation_model');
    }

    /*
     * Listing of cliente
     */
    function index_get()
    {

        $Federation = $this->Federation_model->get_all_federation();
        $this->response($Federation, REST_Controller::HTTP_OK);
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

        $Federation = $this->Federation_model->get_federation($id);

        if(!is_null($Federation)){
            $this->set_response($Federation, REST_Controller::HTTP_OK);
        }else{
            $this->set_response([
                'status' => FALSE,
                'message' => 'Usuario No encontrado'
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
            $this->Federation_model->delete_federation($id);
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