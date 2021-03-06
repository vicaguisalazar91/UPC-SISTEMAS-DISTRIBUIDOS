<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Stage extends CI_Controller{
    function __construct()
    {
        parent::__construct();
        $this->load->model('Stage_model');
    } 

    /*
     * Listing of stage
     */
    function index()
    {
        $data['stage'] = $this->Stage_model->get_all_stage();
        
        $data['_view'] = 'stage/index';
        $this->load->view('layouts/main',$data);
    }

    /*
     * Adding a new stage
     */
    function add()
    {   
        if(isset($_POST) && count($_POST) > 0)     
        {   
            $params = array(
				'TryOutId' => $this->input->post('TryOutId'),
            );
            
            $stage_id = $this->Stage_model->add_stage($params);
            redirect('stage/index');
        }
        else
        {            
            $data['_view'] = 'stage/add';
            $this->load->view('layouts/main',$data);
        }
    }  

    /*
     * Editing a stage
     */
    function edit($StageId)
    {   
        // check if the stage exists before trying to edit it
        $data['stage'] = $this->Stage_model->get_stage($StageId);
        
        if(isset($data['stage']['StageId']))
        {
            if(isset($_POST) && count($_POST) > 0)     
            {   
                $params = array(
					'TryOutId' => $this->input->post('TryOutId'),
                );

                $this->Stage_model->update_stage($StageId,$params);            
                redirect('stage/index');
            }
            else
            {
                $data['_view'] = 'stage/edit';
                $this->load->view('layouts/main',$data);
            }
        }
        else
            show_error('The stage you are trying to edit does not exist.');
    } 

    /*
     * Deleting stage
     */
    function remove($StageId)
    {
        $stage = $this->Stage_model->get_stage($StageId);

        // check if the stage exists before trying to delete it
        if(isset($stage['StageId']))
        {
            $this->Stage_model->delete_stage($StageId);
            redirect('stage/index');
        }
        else
            show_error('The stage you are trying to delete does not exist.');
    }
    
}
