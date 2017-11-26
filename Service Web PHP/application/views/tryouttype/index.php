<div class="pull-right">
	<a href="<?php echo site_url('tryouttype/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>TryOutTypeId</th>
		<th>TryOutTypeDescription</th>
		<th>Actions</th>
    </tr>
	<?php foreach($tryouttype as $T){ ?>
    <tr>
		<td><?php echo $T['TryOutTypeId']; ?></td>
		<td><?php echo $T['TryOutTypeDescription']; ?></td>
		<td>
            <a href="<?php echo site_url('tryouttype/edit/'.$T['TryOutTypeId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('tryouttype/remove/'.$T['TryOutTypeId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
