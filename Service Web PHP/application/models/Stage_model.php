<?php
/* 
 * Generated by CRUDigniter v3.2 
 * www.crudigniter.com
 */
 
class Stage_model extends CI_Model
{
    function __construct()
    {
        parent::__construct();
    }
    
    /*
     * Get stage by StageId
     */
    function get_stage($StageId)
    {
        return $this->db->get_where('Stage',array('StageId'=>$StageId))->row_array();
    }
        
    /*
     * Get all stage
     */
    function get_all_stage()
    {
        $this->db->order_by('StageId', 'desc');
        return $this->db->get('Stage')->result_array();
    }
        
    /*
     * function to add new stage
     */
    function add_stage($params)
    {
        $this->db->insert('Stage',$params);
        return $this->db->insert_id();
    }
    
    /*
     * function to update stage
     */
    function update_stage($StageId,$params)
    {
        $this->db->where('StageId',$StageId);
        return $this->db->update('Stage',$params);
    }
    
    /*
     * function to delete stage
     */
    function delete_stage($StageId)
    {
        return $this->db->delete('Stage',array('StageId'=>$StageId));
    }
}
