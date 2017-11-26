<?php echo form_open('intervention/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="PositionNumber" class="col-md-4 control-label">PositionNumber</label>
		<div class="col-md-8">
			<input type="text" name="PositionNumber" value="<?php echo $this->input->post('PositionNumber'); ?>" class="form-control" id="PositionNumber" />
		</div>
	</div>
	<div class="form-group">
		<label for="TryOutDurationTime" class="col-md-4 control-label">TryOutDurationTime</label>
		<div class="col-md-8">
			<input type="text" name="TryOutDurationTime" value="<?php echo $this->input->post('TryOutDurationTime'); ?>" class="form-control" id="TryOutDurationTime" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>