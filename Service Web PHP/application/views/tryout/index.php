<div class="pull-right">
	<a href="<?php echo site_url('tryout/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>TryOutId</th>
		<th>TryOutName</th>
		<th>TryOutDate</th>
		<th>TryOutWinnerId</th>
		<th>TryOutDurationTime</th>
		<th>TryOutTypeId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($tryout as $T){ ?>
    <tr>
		<td><?php echo $T['TryOutId']; ?></td>
		<td><?php echo $T['TryOutName']; ?></td>
		<td><?php echo $T['TryOutDate']; ?></td>
		<td><?php echo $T['TryOutWinnerId']; ?></td>
		<td><?php echo $T['TryOutDurationTime']; ?></td>
		<td><?php echo $T['TryOutTypeId']; ?></td>
		<td>
            <a href="<?php echo site_url('tryout/edit/'.$T['TryOutId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('tryout/remove/'.$T['TryOutId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
