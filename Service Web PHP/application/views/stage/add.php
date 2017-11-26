<?php echo form_open('stage/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TryOutId" class="col-md-4 control-label">TryOutId</label>
		<div class="col-md-8">
			<input type="text" name="TryOutId" value="<?php echo $this->input->post('TryOutId'); ?>" class="form-control" id="TryOutId" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>