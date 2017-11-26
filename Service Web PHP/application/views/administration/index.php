<div class="pull-right">
	<a href="<?php echo site_url('administration/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>FederationID</th>
		<th>SeasonId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($administration as $A){ ?>
    <tr>
		<td><?php echo $A['FederationID']; ?></td>
		<td><?php echo $A['SeasonId']; ?></td>
		<td>
            <a href="<?php echo site_url('administration/edit/'.$A['FederationID']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('administration/remove/'.$A['FederationID']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
