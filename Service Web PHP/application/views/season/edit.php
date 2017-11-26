<?php echo form_open('season/edit/'.$season['SeasonId'],array("class"=>"form-horizontal")); ?>

	<div class="form-group">
		<label for="SeasonName" class="col-md-4 control-label">SeasonName</label>
		<div class="col-md-8">
			<input type="text" name="SeasonName" value="<?php echo ($this->input->post('SeasonName') ? $this->input->post('SeasonName') : $season['SeasonName']); ?>" class="form-control" id="SeasonName" />
		</div>
	</div>
	<div class="form-group">
		<label for="ContactName" class="col-md-4 control-label">ContactName</label>
		<div class="col-md-8">
			<input type="text" name="ContactName" value="<?php echo ($this->input->post('ContactName') ? $this->input->post('ContactName') : $season['ContactName']); ?>" class="form-control" id="ContactName" />
		</div>
	</div>
	<div class="form-group">
		<label for="SeasonAddress" class="col-md-4 control-label">SeasonAddress</label>
		<div class="col-md-8">
			<input type="text" name="SeasonAddress" value="<?php echo ($this->input->post('SeasonAddress') ? $this->input->post('SeasonAddress') : $season['SeasonAddress']); ?>" class="form-control" id="SeasonAddress" />
		</div>
	</div>
	<div class="form-group">
		<label for="SeasonPhone" class="col-md-4 control-label">SeasonPhone</label>
		<div class="col-md-8">
			<input type="text" name="SeasonPhone" value="<?php echo ($this->input->post('SeasonPhone') ? $this->input->post('SeasonPhone') : $season['SeasonPhone']); ?>" class="form-control" id="SeasonPhone" />
		</div>
	</div>
	<div class="form-group">
		<label for="kilometersNumber" class="col-md-4 control-label">KilometersNumber</label>
		<div class="col-md-8">
			<input type="text" name="kilometersNumber" value="<?php echo ($this->input->post('kilometersNumber') ? $this->input->post('kilometersNumber') : $season['kilometersNumber']); ?>" class="form-control" id="kilometersNumber" />
		</div>
	</div>
	<div class="form-group">
		<label for="QtTracks" class="col-md-4 control-label">QtTracks</label>
		<div class="col-md-8">
			<input type="text" name="QtTracks" value="<?php echo ($this->input->post('QtTracks') ? $this->input->post('QtTracks') : $season['QtTracks']); ?>" class="form-control" id="QtTracks" />
		</div>
	</div>
	
	<div class="form-group">
		<div class="col-sm-offset-4 col-sm-8">
			<button type="submit" class="btn btn-success">Save</button>
        </div>
	</div>
	
<?php echo form_close(); ?>