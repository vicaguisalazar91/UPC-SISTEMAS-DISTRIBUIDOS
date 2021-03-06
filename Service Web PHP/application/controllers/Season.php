<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Season extends CI_Controller{
    function __construct()
    {
        parent::__construct();
        $this->load->model('Season_model');
    } 

    /*
     * Listing of season
     */
    function index()
    {
        $data['season'] = $this->Season_model->get_all_season();
        
        $data['_view'] = 'season/index';
        $this->load->view('layouts/main',$data);
    }

    /*
     * Adding a new season
     */
    function add()
    {   
        if(isset($_POST) && count($_POST) > 0)     
        {   
            $params = array(
				'SeasonName' => $this->input->post('SeasonName'),
				'ContactName' => $this->input->post('ContactName'),
				'SeasonAddress' => $this->input->post('SeasonAddress'),
				'SeasonPhone' => $this->input->post('SeasonPhone'),
				'kilometersNumber' => $this->input->post('kilometersNumber'),
				'QtTracks' => $this->input->post('QtTracks'),
            );
            
            $season_id = $this->Season_model->add_season($params);
            redirect('season/index');
        }
        else
        {            
            $data['_view'] = 'season/add';
            $this->load->view('layouts/main',$data);
        }
    }  

    /*
     * Editing a season
     */
    function edit($SeasonId)
    {   
        // check if the season exists before trying to edit it
        $data['season'] = $this->Season_model->get_season($SeasonId);
        
        if(isset($data['season']['SeasonId']))
        {
            if(isset($_POST) && count($_POST) > 0)     
            {   
                $params = array(
					'SeasonName' => $this->input->post('SeasonName'),
					'ContactName' => $this->input->post('ContactName'),
					'SeasonAddress' => $this->input->post('SeasonAddress'),
					'SeasonPhone' => $this->input->post('SeasonPhone'),
					'kilometersNumber' => $this->input->post('kilometersNumber'),
					'QtTracks' => $this->input->post('QtTracks'),
                );

                $this->Season_model->update_season($SeasonId,$params);            
                redirect('season/index');
            }
            else
            {
                $data['_view'] = 'season/edit';
                $this->load->view('layouts/main',$data);
            }
        }
        else
            show_error('The season you are trying to edit does not exist.');
    } 

    /*
     * Deleting season
     */
    function remove($SeasonId)
    {
        $season = $this->Season_model->get_season($SeasonId);

        // check if the season exists before trying to delete it
        if(isset($season['SeasonId']))
        {
            $this->Season_model->delete_season($SeasonId);
            redirect('season/index');
        }
        else
            show_error('The season you are trying to delete does not exist.');
    }
    
}
