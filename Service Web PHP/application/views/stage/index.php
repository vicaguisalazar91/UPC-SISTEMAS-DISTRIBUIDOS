<div class="pull-right">
	<a href="<?php echo site_url('stage/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>StageId</th>
		<th>TryOutId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($stage as $S){ ?>
    <tr>
		<td><?php echo $S['StageId']; ?></td>
		<td><?php echo $S['TryOutId']; ?></td>
		<td>
            <a href="<?php echo site_url('stage/edit/'.$S['StageId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('stage/remove/'.$S['StageId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
