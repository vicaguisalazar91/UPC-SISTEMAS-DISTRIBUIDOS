<div class="pull-right">
	<a href="<?php echo site_url('track_route/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>RouteId</th>
		<th>TrackId</th>
		<th>SequentialNumber</th>
		<th>Actions</th>
    </tr>
	<?php foreach($track_route as $T){ ?>
    <tr>
		<td><?php echo $T['RouteId']; ?></td>
		<td><?php echo $T['TrackId']; ?></td>
		<td><?php echo $T['SequentialNumber']; ?></td>
		<td>
            <a href="<?php echo site_url('track_route/edit/'.$T['RouteId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('track_route/remove/'.$T['RouteId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
