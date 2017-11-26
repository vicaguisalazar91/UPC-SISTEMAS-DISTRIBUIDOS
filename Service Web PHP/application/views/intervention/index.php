<div class="pull-right">
	<a href="<?php echo site_url('intervention/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>CompetitorId</th>
		<th>StageId</th>
		<th>PositionNumber</th>
		<th>TryOutDurationTime</th>
		<th>Actions</th>
    </tr>
	<?php foreach($intervention as $I){ ?>
    <tr>
		<td><?php echo $I['CompetitorId']; ?></td>
		<td><?php echo $I['StageId']; ?></td>
		<td><?php echo $I['PositionNumber']; ?></td>
		<td><?php echo $I['TryOutDurationTime']; ?></td>
		<td>
            <a href="<?php echo site_url('intervention/edit/'.$I['CompetitorId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('intervention/remove/'.$I['CompetitorId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
