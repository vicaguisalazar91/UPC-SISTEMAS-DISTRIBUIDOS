<?php echo form_open('team/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TeamName" class="col-md-4 control-label">TeamName</label>
		<div class="col-md-8">
			<input type="text" name="TeamName" value="<?php echo $this->input->post('TeamName'); ?>" class="form-control" id="TeamName" />
		</div>
	</div>
	<div class="form-group">
		<label for="CoachName" class="col-md-4 control-label">CoachName</label>
		<div class="col-md-8">
			<input type="text" name="CoachName" value="<?php echo $this->input->post('CoachName'); ?>" class="form-control" id="CoachName" />
		</div>
	</div>
	<div class="form-group">
		<label for="SkiersNumber" class="col-md-4 control-label">SkiersNumber</label>
		<div class="col-md-8">
			<input type="text" name="SkiersNumber" value="<?php echo $this->input->post('SkiersNumber'); ?>" class="form-control" id="SkiersNumber" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>