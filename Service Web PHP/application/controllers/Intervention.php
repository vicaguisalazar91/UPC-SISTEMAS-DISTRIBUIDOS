<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Intervention extends CI_Controller{
    function __construct()
    {
        parent::__construct();
        $this->load->model('Intervention_model');
    } 

    /*
     * Listing of intervention
     */
    function index()
    {
        $data['intervention'] = $this->Intervention_model->get_all_intervention();
        
        $data['_view'] = 'intervention/index';
        $this->load->view('layouts/main',$data);
    }

    /*
     * Adding a new intervention
     */
    function add()
    {   
        if(isset($_POST) && count($_POST) > 0)     
        {   
            $params = array(
				'PositionNumber' => $this->input->post('PositionNumber'),
				'TryOutDurationTime' => $this->input->post('TryOutDurationTime'),
            );
            
            $intervention_id = $this->Intervention_model->add_intervention($params);
            redirect('intervention/index');
        }
        else
        {            
            $data['_view'] = 'intervention/add';
            $this->load->view('layouts/main',$data);
        }
    }  

    /*
     * Editing a intervention
     */
    function edit($CompetitorId)
    {   
        // check if the intervention exists before trying to edit it
        $data['intervention'] = $this->Intervention_model->get_intervention($CompetitorId);
        
        if(isset($data['intervention']['CompetitorId']))
        {
            if(isset($_POST) && count($_POST) > 0)     
            {   
                $params = array(
					'PositionNumber' => $this->input->post('PositionNumber'),
					'TryOutDurationTime' => $this->input->post('TryOutDurationTime'),
                );

                $this->Intervention_model->update_intervention($CompetitorId,$params);            
                redirect('intervention/index');
            }
            else
            {
                $data['_view'] = 'intervention/edit';
                $this->load->view('layouts/main',$data);
            }
        }
        else
            show_error('The intervention you are trying to edit does not exist.');
    } 

    /*
     * Deleting intervention
     */
    function remove($CompetitorId)
    {
        $intervention = $this->Intervention_model->get_intervention($CompetitorId);

        // check if the intervention exists before trying to delete it
        if(isset($intervention['CompetitorId']))
        {
            $this->Intervention_model->delete_intervention($CompetitorId);
            redirect('intervention/index');
        }
        else
            show_error('The intervention you are trying to delete does not exist.');
    }
    
}
