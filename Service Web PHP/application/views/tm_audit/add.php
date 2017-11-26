<?php echo form_open('tm_audit/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TableId" class="col-md-4 control-label">TableId</label>
		<div class="col-md-8">
			<input type="text" name="TableId" value="<?php echo $this->input->post('TableId'); ?>" class="form-control" id="TableId" />
		</div>
	</div>
	<div class="form-group">
		<label for="ActionId" class="col-md-4 control-label">ActionId</label>
		<div class="col-md-8">
			<input type="text" name="ActionId" value="<?php echo $this->input->post('ActionId'); ?>" class="form-control" id="ActionId" />
		</div>
	</div>
	<div class="form-group">
		<label for="AuditDate" class="col-md-4 control-label">AuditDate</label>
		<div class="col-md-8">
			<input type="text" name="AuditDate" value="<?php echo $this->input->post('AuditDate'); ?>" class="form-control" id="AuditDate" />
		</div>
	</div>
	<div class="form-group">
		<label for="UserId" class="col-md-4 control-label">UserId</label>
		<div class="col-md-8">
			<input type="text" name="UserId" value="<?php echo $this->input->post('UserId'); ?>" class="form-control" id="UserId" />
		</div>
	</div>
	<div class="form-group">
		<label for="ModifyId" class="col-md-4 control-label">ModifyId</label>
		<div class="col-md-8">
			<input type="text" name="ModifyId" value="<?php echo $this->input->post('ModifyId'); ?>" class="form-control" id="ModifyId" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>