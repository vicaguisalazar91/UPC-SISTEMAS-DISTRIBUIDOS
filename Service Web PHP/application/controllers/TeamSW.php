<?php
/**
 * Created by PhpStorm.
 * User: Vic Aguilar
 * Date: 26/11/2017
 * Time: 01:05
 */

defined('BASEPATH') OR exit('No direct script access allowed');

require_once APPPATH . '/libraries/REST_Controller.php';

class TeamSW extends REST_Controller
{

    function __construct()
    {
        parent::__construct();
        $this->load->model('Team_model');
    }

    /*
     * Listing of cliente
     */
    function index_get()
    {

        $Team= $this->Team_model->get_all_team();
        $this->response($Team, REST_Controller::HTTP_OK);
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

        $Team = $this->Team_model->get_team($id);

        if(!is_null($Team)){
            $this->set_response($Team, REST_Controller::HTTP_OK);
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
            $this->Team_model->delete_team($id);
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