<div class="pull-right">
	<a href="<?php echo site_url('season/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>SeasonId</th>
		<th>SeasonName</th>
		<th>ContactName</th>
		<th>SeasonAddress</th>
		<th>SeasonPhone</th>
		<th>KilometersNumber</th>
		<th>QtTracks</th>
		<th>Actions</th>
    </tr>
	<?php foreach($season as $S){ ?>
    <tr>
		<td><?php echo $S['SeasonId']; ?></td>
		<td><?php echo $S['SeasonName']; ?></td>
		<td><?php echo $S['ContactName']; ?></td>
		<td><?php echo $S['SeasonAddress']; ?></td>
		<td><?php echo $S['SeasonPhone']; ?></td>
		<td><?php echo $S['kilometersNumber']; ?></td>
		<td><?php echo $S['QtTracks']; ?></td>
		<td>
            <a href="<?php echo site_url('season/edit/'.$S['SeasonId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('season/remove/'.$S['SeasonId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
