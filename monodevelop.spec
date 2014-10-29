#
# spec file for package monodevelop
#
# Copyright (c) 2014 SUSE LINUX Products GmbH, Nuernberg, Germany.
#
# All modifications and additions to the file contributed by third parties
# remain the property of their copyright owners, unless otherwise agreed
# upon. The license for this file, and modifications and additions to the
# file, is the same license as for the pristine package itself (unless the
# license for the pristine package is not an Open Source License, in which
# case the license is the MIT License). An "Open Source License" is a
# license that conforms to the Open Source Definition (Version 1.9)
# published by the Open Source Initiative.

# Please submit bugfixes or comments via http://bugs.opensuse.org/
#


Name:           monodevelop
BuildRequires:  mono-data
BuildRequires:  mono-data-postgresql
BuildRequires:  pkgconfig(glade-sharp-2.0)
BuildRequires:  pkgconfig(glib-sharp-2.0)
BuildRequires:  pkgconfig(gnome-sharp-2.0)
BuildRequires:  pkgconfig(gtk-sharp-2.0)
BuildRequires:  pkgconfig(libgnomeui-2.0)
BuildRequires:  pkgconfig(gconf-sharp-2.0)
BuildRequires:  pkgconfig(gnome-vfs-sharp-2.0)
BuildRequires:  autoconf
BuildRequires:  automake
BuildRequires:  fdupes
BuildRequires:  git
BuildRequires:  hicolor-icon-theme
BuildRequires:  intltool
BuildRequires:  libtool
BuildRequires:  shared-mime-info
%if 0%{?fedora} || 0%{?rhel} || 0%{?centos}
%else
BuildRequires:  update-desktop-files
%endif
BuildRequires:  pkgconfig(mono)
# mono-find-requires searches for libmono-2.0.so.1:
BuildRequires:  pkgconfig(mono-2)
BuildRequires:  pkgconfig(mono-addins)
BuildRequires:  pkgconfig(nuget-core)
BuildRequires:  pkgconfig(nunit) >= 2.6.3
BuildRequires:  pkgconfig(monodoc) >= 3.8
BuildRequires:  pkgconfig(wcf)
# Mono.Cecil.dll requires rsync after it's build
BuildRequires:  rsync
Url:            http://www.monodevelop.com/
Version:        5.5.0.227
Release:        1
Summary:        Full-Featured IDE for Mono and Gtk-Sharp
License:        LGPL-2.1 and MIT
Group:          Development/Tools/IDE
Source:         %{name}_%{version}.orig.tar.bz2
BuildRoot:      %{_tmppath}/%{name}-%{version}-build
BuildArch:      noarch
Requires:       mono-basic
Requires:       mono-entityframework
Requires:       mono-web
Requires:       pkgconfig
Requires:       xsp
Requires:       mono-devel
Requires:       mono(nunit.core) = 2.6.3.0
Requires:       mono(nunit.core.interfaces) = 2.6.3.0
Requires:       mono(nunit.framework) = 2.6.3.0
Requires:       mono(nunit.util) = 2.6.3.0

#%define _use_internal_dependency_generator 0
# TODO: this does not work properly
%define __find_provides env sh -c 'filelist=($(cat)) && { printf "%s\\n" "${filelist[@]}" | %{_prefix}/lib/rpm/find-provides && printf "%s\\n" "${filelist[@]}" | %{_bindir}/mono-find-provides ; } | sort | uniq'
%define __find_requires env sh -c 'filelist=($(cat)) && { printf "%s\\n" "${filelist[@]}" | %{_prefix}/lib/rpm/find-requires && printf "%s\\n" "${filelist[@]}" | %{_bindir}/mono-find-requires ; } | sort | uniq'

%description
MonoDevelop is a full-featured integrated development
environment (IDE) for Mono and Gtk-Sharp primarily designed
for C-Sharp and other .NET languages. It allows to quickly
create desktop and ASP.NET Web applications. Support
for Visual Studio file formats eases porting to Linux.

%package devel
Summary:        Development files for MonoDevelop
Group:          Development/Languages/Mono
Requires:       monodevelop = %{version}

%description devel
MonoDevelop is a full-featured integrated development
environment (IDE) for Mono and Gtk-Sharp. It was originally
a port of SharpDevelop 0.98.

This package contains development files for the IDE and plugins.

%prep
%setup -q -n %{name}-5.5

%build
%{?env_options}

%configure --libdir=%{_prefix}/lib --disable-update-mimedb
make

%install
%{?env_options}
make install DESTDIR=%{buildroot} GACUTIL_FLAGS="/package monodevelop /root %{buildroot}%{_prefix}/lib"
#
mkdir -p %{buildroot}%{_prefix}/share/pkgconfig
mv %{buildroot}%{_prefix}/lib/pkgconfig/* %{buildroot}%{_datadir}/pkgconfig
cp -a /usr/lib/nuget/NuGet.Core.dll %{buildroot}%{_prefix}/lib/monodevelop/AddIns/MonoDevelop.PackageManagement/
cp -a /usr/lib/nuget/Microsoft.Web.XmlTransform.dll %{buildroot}%{_prefix}/lib/monodevelop/AddIns/MonoDevelop.PackageManagement/
ln -s /usr/lib/mono/nunit/nunit.core.dll %{buildroot}%{_prefix}/lib/monodevelop/AddIns/NUnit/
ln -s /usr/lib/mono/nunit/nunit.core.interfaces.dll %{buildroot}%{_prefix}/lib/monodevelop/AddIns/NUnit/
ln -s /usr/lib/mono/nunit/nunit.framework.dll %{buildroot}%{_prefix}/lib/monodevelop/AddIns/NUnit/
ln -s /usr/lib/mono/nunit/nunit.util.dll %{buildroot}%{_prefix}/lib/monodevelop/AddIns/NUnit/
%find_lang %{name}
%if 0%{?suse_version} > 1220
%fdupes %buildroot/%{_prefix}
%endif

%post
%if 0%{?rhel}%{?fedora}%{?centos}
  /bin/touch --no-create %{_datadir}/icons/hicolor &>/dev/null || :
  %{_bindir}/update-desktop-database &> /dev/null || :
%else
  %if 0%{?suse_version}
    %desktop_database_post
    %icon_theme_cache_post
    %mime_database_post
  %endif
%endif

%postun
%if 0%{?rhel}%{?fedora}%{?centos}
  %{_bindir}/update-desktop-database &> /dev/null || :
  if [ $1 -eq 0 ] ; then
    /bin/touch --no-create %{_datadir}/icons/hicolor &>/dev/null
    %{_bindir}/gtk-update-icon-cache %{_datadir}/icons/hicolor &>/dev/null || :
  fi
%else
  %if 0%{?suse_version}
    %desktop_database_postun
    %icon_theme_cache_postun
    %mime_database_postun
  %endif
%endif

%files -f %{name}.lang
%defattr(-,root,root)
%{_bindir}/*
%defattr(0644,root,root)
%{_datadir}/applications/monodevelop.desktop
%{_datadir}/icons/hicolor/*/apps/monodevelop.png
%{_datadir}/icons/hicolor/scalable/apps/monodevelop.svg
%{_prefix}/lib/monodevelop
%{_mandir}/man1/mdtool.1.gz
%{_mandir}/man1/monodevelop.1.gz
%{_datadir}/mime/packages/monodevelop.xml

%files devel
%defattr(-,root,root)
%{_datadir}/pkgconfig/*.pc

%changelog

