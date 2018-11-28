    <script type="text/javascript">

        function OnGridFocusedRowChanged(s, e) {
            var workflowId = s.GetRowKey(s.GetFocusedRowIndex());

            if (workflowId) {
                $.ajax({
                    url: '/Workflows/_Detail?WorkflowId=' + workflowId,
                    cache: false,
                    type: "Get",
                    success: function (result) {
                        $('#siteContainer').html(result);
                    }
                });
            }
        }

    </script>
