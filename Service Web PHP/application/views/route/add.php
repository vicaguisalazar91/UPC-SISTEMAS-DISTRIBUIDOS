<?php echo form_open('route/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="SeasonId" class="col-md-4 control-label">SeasonId</label>
		<div class="col-md-8">
			<input type="text" name="SeasonId" value="<?php echo $this->input->post('SeasonId'); ?>" class="form-control" id="SeasonId" />
		</div>
	</div>
	<div class="form-group">
		<label for="StageId" class="col-md-4 control-label">StageId</label>
		<div class="col-md-8">
			<input type="text" name="StageId" value="<?php echo $this->input->post('StageId'); ?>" class="form-control" id="StageId" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>