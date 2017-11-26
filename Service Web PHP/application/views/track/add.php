<?php echo form_open('track/add',array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="TrackLength" class="col-md-4 control-label">TrackLength</label>
		<div class="col-md-8">
			<input type="text" name="TrackLength" value="<?php echo $this->input->post('TrackLength'); ?>" class="form-control" id="TrackLength" />
		</div>
	</div>
	<div class="form-group">
		<label for="difficultylevel" class="col-md-4 control-label">Difficultylevel</label>
		<div class="col-md-8">
			<input type="text" name="difficultylevel" value="<?php echo $this->input->post('difficultylevel'); ?>" class="form-control" id="difficultylevel" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>

<?php echo form_close(); ?>