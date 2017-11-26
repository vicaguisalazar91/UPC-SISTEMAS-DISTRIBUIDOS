<?php echo form_open('teammember/edit/'.$teammember['TeamMemberId'],array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TeamId" class="col-md-4 control-label">TeamId</label>
		<div class="col-md-8">
			<input type="text" name="TeamId" value="<?php echo ($this->input->post('TeamId') ? $this->input->post('TeamId') : $teammember['TeamId']); ?>" class="form-control" id="TeamId" />
		</div>
	</div>
	<div class="form-group">
		<label for="NumberId" class="col-md-4 control-label">NumberId</label>
		<div class="col-md-8">
			<input type="text" name="NumberId" value="<?php echo ($this->input->post('NumberId') ? $this->input->post('NumberId') : $teammember['NumberId']); ?>" class="form-control" id="NumberId" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>
	
<?php echo form_close(); ?>