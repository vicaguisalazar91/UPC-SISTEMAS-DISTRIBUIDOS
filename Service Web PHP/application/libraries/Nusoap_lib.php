<?php if (!defined('BASEPATH')) exit('No direct script access allowed');

class Nusoap_lib {
	
	public function __construct()
    {
		require_once(str_replace("\\","/",APPPATH).'libraries/lib/nusoap.php');
    }
    
}

?>