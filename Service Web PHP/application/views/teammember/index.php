<div class="pull-right">
	<a href="<?php echo site_url('teammember/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>TeamMemberId</th>
		<th>TeamId</th>
		<th>NumberId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($teammember as $T){ ?>
    <tr>
		<td><?php echo $T['TeamMemberId']; ?></td>
		<td><?php echo $T['TeamId']; ?></td>
		<td><?php echo $T['NumberId']; ?></td>
		<td>
            <a href="<?php echo site_url('teammember/edit/'.$T['TeamMemberId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('teammember/remove/'.$T['TeamMemberId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
