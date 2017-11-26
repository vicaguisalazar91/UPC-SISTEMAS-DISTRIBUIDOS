<div class="pull-right">
	<a href="<?php echo site_url('competitor/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>CompetitorId</th>
		<th>NumberId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($competitor as $C){ ?>
    <tr>
		<td><?php echo $C['CompetitorId']; ?></td>
		<td><?php echo $C['NumberId']; ?></td>
		<td>
            <a href="<?php echo site_url('competitor/edit/'.$C['CompetitorId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('competitor/remove/'.$C['CompetitorId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
