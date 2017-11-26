<div class="pull-right">
	<a href="<?php echo site_url('team/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>TeamId</th>
		<th>TeamName</th>
		<th>CoachName</th>
		<th>SkiersNumber</th>
		<th>Actions</th>
    </tr>
	<?php foreach($team as $T){ ?>
    <tr>
		<td><?php echo $T['TeamId']; ?></td>
		<td><?php echo $T['TeamName']; ?></td>
		<td><?php echo $T['CoachName']; ?></td>
		<td><?php echo $T['SkiersNumber']; ?></td>
		<td>
            <a href="<?php echo site_url('team/edit/'.$T['TeamId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('team/remove/'.$T['TeamId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
