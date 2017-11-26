<div class="pull-right">
	<a href="<?php echo site_url('track/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>TrackId</th>
		<th>TrackLength</th>
		<th>Difficultylevel</th>
		<th>Actions</th>
    </tr>
	<?php foreach($track as $T){ ?>
    <tr>
		<td><?php echo $T['TrackId']; ?></td>
		<td><?php echo $T['TrackLength']; ?></td>
		<td><?php echo $T['difficultylevel']; ?></td>
		<td>
            <a href="<?php echo site_url('track/edit/'.$T['TrackId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('track/remove/'.$T['TrackId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
