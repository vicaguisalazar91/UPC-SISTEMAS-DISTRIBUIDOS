<div class="pull-right">
	<a href="<?php echo site_url('route/add'); ?>" class="btn btn-success">Add</a> 
</div>

<table class="table table-striped table-bordered">
    <tr>
		<th>RouteId</th>
		<th>SeasonId</th>
		<th>StageId</th>
		<th>Actions</th>
    </tr>
	<?php foreach($route as $R){ ?>
    <tr>
		<td><?php echo $R['RouteId']; ?></td>
		<td><?php echo $R['SeasonId']; ?></td>
		<td><?php echo $R['StageId']; ?></td>
		<td>
            <a href="<?php echo site_url('route/edit/'.$R['RouteId']); ?>" class="btn btn-info btn-xs">Edit</a> 
            <a href="<?php echo site_url('route/remove/'.$R['RouteId']); ?>" class="btn btn-danger btn-xs">Delete</a>
        </td>
    </tr>
	<?php } ?>
</table>
