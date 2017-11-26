<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Season_model extends CI_Model
{
    function __construct()
    {
        parent::__construct();
    }
    
    /*
     * Get season by SeasonId
     */
    function get_season($SeasonId)
    {
        return $this->db->get_where('Season',array('SeasonId'=>$SeasonId))->row_array();
    }
        
    /*
     * Get all season
     */
    function get_all_season()
    {
        $this->db->order_by('SeasonId', 'desc');
        return $this->db->get('Season')->result_array();
    }
        
    /*
     * function to add new season
     */
    function add_season($params)
    {
        $this->db->insert('Season',$params);
        return $this->db->insert_id();
    }
    
    /*
     * function to update season
     */
    function update_season($SeasonId,$params)
    {
        $this->db->where('SeasonId',$SeasonId);
        return $this->db->update('Season',$params);
    }
    
    /*
     * function to delete season
     */
    function delete_season($SeasonId)
    {
        return $this->db->delete('Season',array('SeasonId'=>$SeasonId));
    }
}
