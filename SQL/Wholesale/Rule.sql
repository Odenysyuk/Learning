USE wholesale;
GO

CREATE DEFAULT sex_deff AS 'f';
GO

CREATE RULE sex_rule AS @var='f' OR @var='m'
GO

CREATE DEFAULT Packaging_deff AS 'pc';
GO

CREATE DEFAULT Delivery_deff AS 'self';
GO

CREATE RULE Packaging_rule AS @var='pc' OR @var='pcg' OR @var='bay'
GO

CREATE RULE Delivery_rule AS @var='self' OR @var='ByCarrier' 
GO

