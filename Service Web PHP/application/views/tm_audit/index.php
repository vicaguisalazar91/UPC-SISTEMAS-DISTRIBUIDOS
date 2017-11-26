<div class="pull-right">
	<a href="<?php echo site_url('tm_audit/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>TableId</th>
		<th>ActionId</th>
		<th>AuditDate</th>
		<th>UserId</th>
		<th>ModifyId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($tm_audit as $T){ ?>
    <tr>
		<td><?php echo $T['TableId']; ?></td>
		<td><?php echo $T['ActionId']; ?></td>
		<td><?php echo $T['AuditDate']; ?></td>
		<td><?php echo $T['UserId']; ?></td>
		<td><?php echo $T['ModifyId']; ?></td>
		<td>
            <a href="<?php echo site_url('tm_audit/edit/'.$T['']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('tm_audit/remove/'.$T['']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
