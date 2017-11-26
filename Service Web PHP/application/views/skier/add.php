<?php echo form_open('skier/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="SkierName" class="col-md-4 control-label">SkierName</label>
		<div class="col-md-8">
			<input type="text" name="SkierName" value="<?php echo $this->input->post('SkierName'); ?>" class="form-control" id="SkierName" />
		</div>
	</div>
	<div class="form-group">
		<label for="Birthdate" class="col-md-4 control-label">Birthdate</label>
		<div class="col-md-8">
			<input type="text" name="Birthdate" value="<?php echo $this->input->post('Birthdate'); ?>" class="form-control" id="Birthdate" />
		</div>
	</div>
	<div class="form-group">
		<label for="FederationID" class="col-md-4 control-label">FederationID</label>
		<div class="col-md-8">
			<input type="text" name="FederationID" value="<?php echo $this->input->post('FederationID'); ?>" class="form-control" id="FederationID" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>