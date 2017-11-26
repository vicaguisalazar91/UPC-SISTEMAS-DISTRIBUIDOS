<div class="pull-right">
	<a href="<?php echo site_url('user/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>UserId</th>
		<th>UserName</th>
		<th>UserPassword</th>
		<th>Actions</th>
    </tr>
	<?php foreach($user as $U){ ?>
    <tr>
		<td><?php echo $U['UserId']; ?></td>
		<td><?php echo $U['UserName']; ?></td>
		<td><?php echo $U['UserPassword']; ?></td>
		<td>
            <a href="<?php echo site_url('user/edit/'.$U['UserId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('user/remove/'.$U['UserId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
