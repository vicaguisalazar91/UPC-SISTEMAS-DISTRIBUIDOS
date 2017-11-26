<?php echo form_open('skier/edit/'.$skier['NumberId'],array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="SkierName" class="col-md-4 control-label">SkierName</label>
		<div class="col-md-8">
			<input type="text" name="SkierName" value="<?php echo ($this->input->post('SkierName') ? $this->input->post('SkierName') : $skier['SkierName']); ?>" class="form-control" id="SkierName" />
		</div>
	</div>
	<div class="form-group">
		<label for="Birthdate" class="col-md-4 control-label">Birthdate</label>
		<div class="col-md-8">
			<input type="text" name="Birthdate" value="<?php echo ($this->input->post('Birthdate') ? $this->input->post('Birthdate') : $skier['Birthdate']); ?>" class="form-control" id="Birthdate" />
		</div>
	</div>
	<div class="form-group">
		<label for="FederationID" class="col-md-4 control-label">FederationID</label>
		<div class="col-md-8">
			<input type="text" name="FederationID" value="<?php echo ($this->input->post('FederationID') ? $this->input->post('FederationID') : $skier['FederationID']); ?>" class="form-control" id="FederationID" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>
	
<?php echo form_close(); ?>