<?php echo form_open('competitor/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="NumberId" class="col-md-4 control-label">NumberId</label>
		<div class="col-md-8">
			<input type="text" name="NumberId" value="<?php echo $this->input->post('NumberId'); ?>" class="form-control" id="NumberId" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>