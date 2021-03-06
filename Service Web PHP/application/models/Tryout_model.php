<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Tryout_model extends CI_Model
{
    function __construct()
    {
        parent::__construct();
    }
    
    /*
     * Get tryout by TryOutId
     */
    function get_tryout($TryOutId)
    {
        return $this->db->get_where('TryOut',array('TryOutId'=>$TryOutId))->row_array();
    }
        
    /*
     * Get all tryout
     */
    function get_all_tryout()
    {
        $this->db->order_by('TryOutId', 'desc');
        return $this->db->get('TryOut')->result_array();
    }
        
    /*
     * function to add new tryout
     */
    function add_tryout($params)
    {
        $this->db->insert('TryOut',$params);
        return $this->db->insert_id();
    }
    
    /*
     * function to update tryout
     */
    function update_tryout($TryOutId,$params)
    {
        $this->db->where('TryOutId',$TryOutId);
        return $this->db->update('TryOut',$params);
    }
    
    /*
     * function to delete tryout
     */
    function delete_tryout($TryOutId)
    {
        return $this->db->delete('TryOut',array('TryOutId'=>$TryOutId));
    }
}
