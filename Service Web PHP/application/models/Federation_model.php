<?php
/**
 * Created by PhpStorm.
 * User: Vic Aguilar
 * Date: 18/11/2017
 * Time: 08:12
 */

class Federation_model extends  CI_Model
{

    public  function addFederation($data){

        $condition = "FederationName =" . "'" . $data['FederationName'] . "'";
        $this->db->select('*');
        $this->db->from('Federation');
        $this->db->where($condition);
        $this->db->limit(1);
        $query = $this->db->get();
        if ($query->num_rows() == 0) {
            // Query to insert data in database
            $this->db->insert('Federation', $data);
            if ($this->db->affected_rows() > 0) {
                return true;
            }
        } else {
            return false;
        }
    }

}