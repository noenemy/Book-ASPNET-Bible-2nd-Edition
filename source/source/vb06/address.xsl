<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<body>
		XML 주소록<br />
		<table border="1" cellpadding="0" cellspacing="0" width="80%">
					<tr bgcolor="beige">
						<td>이름</td>
						<td>e-mail</td>
						<td>전화번호</td>
					</tr>
					<xsl:for-each select="addressbook/member">
						<tr>
							<td>
								<xsl:value-of select="name" />
							</td>
							<td>
								<xsl:value-of select="email" />
							</td>
							<td>
								<xsl:value-of select="phone" />
							</td>
						</tr>
					</xsl:for-each>
				</table>
	</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
