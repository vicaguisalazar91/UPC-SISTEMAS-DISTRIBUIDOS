<?php echo form_open('track_route/edit/'.$track_route['RouteId'],array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="SequentialNumber" class="col-md-4 control-label">SequentialNumber</label>
		<div class="col-md-8">
			<input type="text" name="SequentialNumber" value="<?php echo ($this->input->post('SequentialNumber') ? $this->input->post('SequentialNumber') : $track_route['SequentialNumber']); ?>" class="form-control" id="SequentialNumber" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>
	
<?php echo form_close(); ?>