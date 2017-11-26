<?php echo form_open('tryouttype/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TryOutTypeDescription" class="col-md-4 control-label">TryOutTypeDescription</label>
		<div class="col-md-8">
			<input type="text" name="TryOutTypeDescription" value="<?php echo $this->input->post('TryOutTypeDescription'); ?>" class="form-control" id="TryOutTypeDescription" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>