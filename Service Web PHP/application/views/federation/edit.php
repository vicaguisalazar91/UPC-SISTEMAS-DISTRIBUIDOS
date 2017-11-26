<?php echo form_open('federation/edit/'.$federation['FederationID'],array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="FederationName" class="col-md-4 control-label">FederationName</label>
		<div class="col-md-8">
			<input type="text" name="FederationName" value="<?php echo ($this->input->post('FederationName') ? $this->input->post('FederationName') : $federation['FederationName']); ?>" class="form-control" id="FederationName" />
		</div>
	</div>
	<div class="form-group">
		<label for="FederatedNumber" class="col-md-4 control-label">FederatedNumber</label>
		<div class="col-md-8">
			<input type="text" name="FederatedNumber" value="<?php echo ($this->input->post('FederatedNumber') ? $this->input->post('FederatedNumber') : $federation['FederatedNumber']); ?>" class="form-control" id="FederatedNumber" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>
	
<?php echo form_close(); ?>