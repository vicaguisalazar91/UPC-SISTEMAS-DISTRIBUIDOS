<?php echo form_open('tryout/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TryOutName" class="col-md-4 control-label">TryOutName</label>
		<div class="col-md-8">
			<input type="text" name="TryOutName" value="<?php echo $this->input->post('TryOutName'); ?>" class="form-control" id="TryOutName" />
		</div>
	</div>
	<div class="form-group">
		<label for="TryOutDate" class="col-md-4 control-label">TryOutDate</label>
		<div class="col-md-8">
			<input type="text" name="TryOutDate" value="<?php echo $this->input->post('TryOutDate'); ?>" class="form-control" id="TryOutDate" />
		</div>
	</div>
	<div class="form-group">
		<label for="TryOutWinnerId" class="col-md-4 control-label">TryOutWinnerId</label>
		<div class="col-md-8">
			<input type="text" name="TryOutWinnerId" value="<?php echo $this->input->post('TryOutWinnerId'); ?>" class="form-control" id="TryOutWinnerId" />
		</div>
	</div>
	<div class="form-group">
		<label for="TryOutDurationTime" class="col-md-4 control-label">TryOutDurationTime</label>
		<div class="col-md-8">
			<input type="text" name="TryOutDurationTime" value="<?php echo $this->input->post('TryOutDurationTime'); ?>" class="form-control" id="TryOutDurationTime" />
		</div>
	</div>
	<div class="form-group">
		<label for="TryOutTypeId" class="col-md-4 control-label">TryOutTypeId</label>
		<div class="col-md-8">
			<input type="text" name="TryOutTypeId" value="<?php echo $this->input->post('TryOutTypeId'); ?>" class="form-control" id="TryOutTypeId" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>