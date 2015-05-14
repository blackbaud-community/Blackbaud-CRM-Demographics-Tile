/*
  Insert row for custom event registrations tile.
  Set name to 'Event Registrations' and specify
  individual constituent type. Do not display by default.
*/

declare @CHANGEAGENTID uniqueidentifier;
declare @CURRENTDATE datetime = getdate();

exec dbo.USP_CHANGEAGENT_GETORCREATECHANGEAGENT @CHANGEAGENTID
output;

if not exists(
  select 1
  from dbo.CONSTITUENTSUMMARYAVAILABLETILE
  where DATAFORMINSTANCECATALOGID = '473bed00-d274-48bd-abc1-535b27c1a24d' and CONSTITUENTTYPECODE = 0
)
begin
  insert into CONSTITUENTSUMMARYAVAILABLETILE(
    TILENAME,
    CONSTITUENTTYPECODE,
    DATAFORMINSTANCECATALOGID,
    DATEADDED,
    DATECHANGED,
    ADDEDBYID,
    CHANGEDBYID
  )
  values(
    'Demographics',
    0,
    '473bed00-d274-48bd-abc1-535b27c1a24d',
    @CURRENTDATE,
    @CURRENTDATE,
    @CHANGEAGENTID,
    @CHANGEAGENTID
  );
end
