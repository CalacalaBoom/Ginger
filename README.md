# Ginger
.NET6 ASP.NET WebApi快速开发模板，目前集成sqlsugar、RESTFul

# 第一步 生成多项目模板
在项目菜单中选择导出模板

![生成多项目模板](https://img2020.cnblogs.com/blog/402798/202012/402798-20201215093706244-1415702468.png)

导出模板对话框中选项目模板，并选择具体导出的单个项目

![生成多项目模板](https://raw.githubusercontent.com/CalacalaBoom/Ginger/master/docs/%E5%B1%8F%E5%B9%95%E6%88%AA%E5%9B%BE%202024-02-28%20084030.png)

项目模板以.zip格式导出到指定目录

![生成多项目模板](https://raw.githubusercontent.com/CalacalaBoom/Ginger/master/docs/%E5%B1%8F%E5%B9%95%E6%88%AA%E5%9B%BE%202024-02-28%20084118.png)

重复以上步骤，把整个解决方案中的项目分别导出



# 第二步 解压缩

以上步骤完成后，新建目录，将所有.zip文件解压到该目录中



# 第三步 创建模板文件
创建名为 MultiProjectTemplate.vstemplate 的模板文件

![生成多项目模板](https://raw.githubusercontent.com/CalacalaBoom/Ginger/master/docs/%E5%B1%8F%E5%B9%95%E6%88%AA%E5%9B%BE%202024-02-28%20084143.png)

# 第四步 修改模板信息
模板格式，Name是模板的名称，LanguageTag和PlatformTag都是模板的标签，ProjectCollection中包含的是项目集合

<VSTemplate Version="2.0.0" Type="ProjectGroup"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">

	<TemplateData>
		<Name>Ginger</Name>
		<Description>ASP.NET WebApi+SqlSugar开发模板</Description>
		<Icon>logo.ico</Icon>
		<ProjectType>CSharp</ProjectType>
		<LanguageTag>C#</LanguageTag>
		<PlatformTag>Web APi</PlatformTag>
		<PlatformTag>SqlSugar</PlatformTag>
		<ProjectTypeTag>CSharp</ProjectTypeTag>
	</TemplateData>
	<TemplateContent>
		<ProjectCollection>
			<ProjectTemplateLink ProjectName="Ginger" CopyParameters="true">
				Ginger\MyTemplate.vstemplate
			</ProjectTemplateLink>
			<ProjectTemplateLink ProjectName="Ginger.Comon" CopyParameters="true">
				Ginger.Comon\MyTemplate.vstemplate
			</ProjectTemplateLink>
			<ProjectTemplateLink ProjectName="Ginger.Core" CopyParameters="true">
				Ginger.Core\MyTemplate.vstemplate
			</ProjectTemplateLink>
		</ProjectCollection>
	</TemplateContent>
</VSTemplate>

# 第五步 导入模板
模板编辑完成后将改目录打成.zip格式的压缩包，将 .zip 文件复制到用户项目模板目录中

默认情况下，此目录为 %USERPROFILE%\Documents\Visual Studio <version>\Templates\ProjectTemplates。

例如：C:\Users\Administrator\Documents\Visual Studio 2019\Templates\ProjectTemplates

重新打开vs，新建项目时在模板列表中可以看到刚才制作的模板

![生成多项目模板](https://raw.githubusercontent.com/CalacalaBoom/Ginger/master/docs/%E5%B1%8F%E5%B9%95%E6%88%AA%E5%9B%BE%202024-02-28%20084816.png)
