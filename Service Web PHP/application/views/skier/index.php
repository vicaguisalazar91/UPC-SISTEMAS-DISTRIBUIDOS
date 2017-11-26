<div class="pull-right">
	<a href="<?php echo site_url('skier/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>NumberId</th>
		<th>SkierName</th>
		<th>Birthdate</th>
		<th>FederationID</th>
		<th>Actions</th>
    </tr>
	<?php foreach($skier as $S){ ?>
    <tr>
		<td><?php echo $S['NumberId']; ?></td>
		<td><?php echo $S['SkierName']; ?></td>
		<td><?php echo $S['Birthdate']; ?></td>
		<td><?php echo $S['FederationID']; ?></td>
		<td>
            <a href="<?php echo site_url('skier/edit/'.$S['NumberId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('skier/remove/'.$S['NumberId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
