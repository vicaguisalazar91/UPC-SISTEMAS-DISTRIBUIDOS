<?php echo form_open('user/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="UserName" class="col-md-4 control-label">UserName</label>
		<div class="col-md-8">
			<input type="text" name="UserName" value="<?php echo $this->input->post('UserName'); ?>" class="form-control" id="UserName" />
		</div>
	</div>
	<div class="form-group">
		<label for="UserPassword" class="col-md-4 control-label">UserPassword</label>
		<div class="col-md-8">
			<input type="text" name="UserPassword" value="<?php echo $this->input->post('UserPassword'); ?>" class="form-control" id="UserPassword" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>