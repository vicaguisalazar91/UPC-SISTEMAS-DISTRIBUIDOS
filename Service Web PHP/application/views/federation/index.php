<div class="pull-right">
	<a href="<?php echo site_url('federation/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>FederationID</th>
		<th>FederationName</th>
		<th>FederatedNumber</th>
		<th>Actions</th>
    </tr>
	<?php foreach($federation as $F){ ?>
    <tr>
		<td><?php echo $F['FederationID']; ?></td>
		<td><?php echo $F['FederationName']; ?></td>
		<td><?php echo $F['FederatedNumber']; ?></td>
		<td>
            <a href="<?php echo site_url('federation/edit/'.$F['FederationID']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('federation/remove/'.$F['FederationID']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
