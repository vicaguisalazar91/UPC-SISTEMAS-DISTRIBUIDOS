<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Tryout extends CI_Controller{
    function __construct()
    {
        parent::__construct();
        $this->load->model('Tryout_model');
    } 

    /*
     * Listing of tryout
     */
    function index()
    {
        $data['tryout'] = $this->Tryout_model->get_all_tryout();
        
        $data['_view'] = 'tryout/index';
        $this->load->view('layouts/main',$data);
    }

    /*
     * Adding a new tryout
     */
    function add()
    {   
        if(isset($_POST) && count($_POST) > 0)     
        {   
            $params = array(
				'TryOutName' => $this->input->post('TryOutName'),
				'TryOutDate' => $this->input->post('TryOutDate'),
				'TryOutWinnerId' => $this->input->post('TryOutWinnerId'),
				'TryOutDurationTime' => $this->input->post('TryOutDurationTime'),
				'TryOutTypeId' => $this->input->post('TryOutTypeId'),
            );
            
            $tryout_id = $this->Tryout_model->add_tryout($params);
            redirect('tryout/index');
        }
        else
        {            
            $data['_view'] = 'tryout/add';
            $this->load->view('layouts/main',$data);
        }
    }  

    /*
     * Editing a tryout
     */
    function edit($TryOutId)
    {   
        // check if the tryout exists before trying to edit it
        $data['tryout'] = $this->Tryout_model->get_tryout($TryOutId);
        
        if(isset($data['tryout']['TryOutId']))
        {
            if(isset($_POST) && count($_POST) > 0)     
            {   
                $params = array(
					'TryOutName' => $this->input->post('TryOutName'),
					'TryOutDate' => $this->input->post('TryOutDate'),
					'TryOutWinnerId' => $this->input->post('TryOutWinnerId'),
					'TryOutDurationTime' => $this->input->post('TryOutDurationTime'),
					'TryOutTypeId' => $this->input->post('TryOutTypeId'),
                );

                $this->Tryout_model->update_tryout($TryOutId,$params);            
                redirect('tryout/index');
            }
            else
            {
                $data['_view'] = 'tryout/edit';
                $this->load->view('layouts/main',$data);
            }
        }
        else
            show_error('The tryout you are trying to edit does not exist.');
    } 

    /*
     * Deleting tryout
     */
    function remove($TryOutId)
    {
        $tryout = $this->Tryout_model->get_tryout($TryOutId);

        // check if the tryout exists before trying to delete it
        if(isset($tryout['TryOutId']))
        {
            $this->Tryout_model->delete_tryout($TryOutId);
            redirect('tryout/index');
        }
        else
            show_error('The tryout you are trying to delete does not exist.');
    }
    
}
