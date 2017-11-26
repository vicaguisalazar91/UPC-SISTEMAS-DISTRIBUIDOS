<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Team_model extends CI_Model
{
    function __construct()
    {
        parent::__construct();
    }
    
    /*
     * Get team by TeamId
     */
    function get_team($TeamId)
    {
        return $this->db->get_where('Team',array('TeamId'=>$TeamId))->row_array();
    }
        
    /*
     * Get all team
     */
    function get_all_team()
    {
        $this->db->order_by('TeamId', 'desc');
        return $this->db->get('Team')->result_array();
    }
        
    /*
     * function to add new team
     */
    function add_team($params)
    {
        $this->db->insert('Team',$params);
        return $this->db->insert_id();
    }
    
    /*
     * function to update team
     */
    function update_team($TeamId,$params)
    {
        $this->db->where('TeamId',$TeamId);
        return $this->db->update('Team',$params);
    }
    
    /*
     * function to delete team
     */
    function delete_team($TeamId)
    {
        return $this->db->delete('Team',array('TeamId'=>$TeamId));
    }
}
